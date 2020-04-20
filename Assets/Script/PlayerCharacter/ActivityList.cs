using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;

/// <summary>
/// This class maintains a running total of the players actions in order to grant the score at the end of the game.
/// </summary>
public class ActivityList : MonoBehaviour
{
    public List<Activity> MasterList;

    [ReadOnly]
    public double CurrentDamages = 0.0; //For debugging purposes, the current "running total" can and should be visible from the inspector.

    void LateUpdate()
    { //Slapping this shit in lateupdate so it doesn't lag the client. Remove this on release and DONT FORGET OMGDSHGL:NKSJDNHGL:EDSFKJHN
        if (GetTotalDamageCost() != 0.0)
        CurrentDamages = GetTotalDamageCost();    
    }

    void Start()
    {
        MasterList = new List<Activity>();
        //Cheekily create a starting activity so that even if the player doesn't do anything, the lab still charges them because capitalism!
        Activity nActivity = new Activity();
        nActivity.ActivityCost = 50.0;
        nActivity.ActivityName = "Lab Fee";
        MasterList.Add(nActivity);
    }
    
    public void AddActivity(string ActivityName, double Cost)
    {
        Activity nActivity = new Activity();
        nActivity.ActivityCost = Cost;
        nActivity.ActivityName = ActivityName;
        MasterList.Add(nActivity);
        Debug.Log($"Added {nActivity.ActivityName} with the cost of ${nActivity.ActivityCost.ToString()}");
    }

    /// <summary>
    /// This method generates an itemized list (hah) of all the activities that were performed and their associated costs.
    /// </summary>
    /// <returns></returns>
    public string GetActivityPrintout()
    {
        string Result = "";
        for (int i = 0; i < MasterList.Count; i++)
        {
            Result += $"- {MasterList[i].ActivityName} - ${MasterList[i].ActivityCost.ToString()}\n";
        }
        return Result;

    }

    /// <summary>
    /// Get the raw number of damages (sans currency indicator)
    /// </summary>
    /// <returns></returns>
    public double GetTotalDamageCost()
    {
        double Result = 0.0;
        for (int i = 0; i < MasterList.Count; i++)
        {
            Result += MasterList[i].ActivityCost;
        }
        return Result;
    }

    public struct Activity
    {
        public string ActivityName;
        public double ActivityCost;

    }
}
