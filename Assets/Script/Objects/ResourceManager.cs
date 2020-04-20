using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.SceneManagement;


public class ResourceManager : MonoBehaviour
{
    public float FoodTotal;
    public float EntertainmentTotal;
    public float HeatTotal;
    public float WaterTotal;

    public float HealthTotal;

    public bool SFXEnabled = true;

    [BoxGroup("Configuration")]
    public float HeatIncrementPerSecond;
    [BoxGroup("Configuration")]
    public float FoodDecayPerSecond;
    [BoxGroup("Configuration")]
    public float WaterDecayPerSecond;
    [BoxGroup("Configuration")]
    public float EntertainmentDecayPerSecond;

    [BoxGroup("Starting Values")]
    public float DefaultFood;
    [BoxGroup("Starting Values")]
    public float DefaultEntertainment;
    [BoxGroup("Starting Values")]
    public float DefaultWater;
    [BoxGroup("Starting Values")]
    public float DefaultHeat;

    [BoxGroup("Objects")]
    GameObject HeatBar;
    [BoxGroup("Objects")]
    GameObject EntertainmentBar;
    [BoxGroup("Objects")]
    GameObject WaterBar;
    [BoxGroup("Objects")]
    GameObject FoodBar;
    [BoxGroup("Objects")]
    GameObject HealthBar;

    SpriteFillBar HeatBarFill;
    SpriteFillBar EntBarFill;
    SpriteFillBar WaterBarFill;
    SpriteFillBar FoodBarFill;
    SpriteFillBar HealthBarFill;

    void Start()
    {
        HealthTotal = 1.0f;
        HeatBar = GameObject.FindGameObjectWithTag("HeatBar");
        HeatBarFill = HeatBar.GetComponent<SpriteFillBar>();

        WaterBar = GameObject.FindGameObjectWithTag("WaterBar");
        WaterBarFill = WaterBar.GetComponent<SpriteFillBar>();

        EntertainmentBar = GameObject.FindGameObjectWithTag("EntertainmentBar");
        EntBarFill = EntertainmentBar.GetComponent<SpriteFillBar>();

        FoodBar = GameObject.FindGameObjectWithTag("FoodBar");
        FoodBarFill = FoodBar.GetComponent<SpriteFillBar>();

        HealthBar = GameObject.FindGameObjectWithTag("HealthBar");
        HealthBarFill = HealthBar.GetComponent<SpriteFillBar>();

        FoodBarFill.SetFillBar(DefaultFood);
        WaterBarFill.SetFillBar(DefaultWater);
        EntBarFill.SetFillBar(DefaultEntertainment);
        HealthBarFill.SetFillBar(HealthTotal);
        HeatBarFill.SetFillBar(DefaultHeat);

        WaterTotal = DefaultWater;
        FoodTotal = DefaultFood;
        EntertainmentTotal = DefaultEntertainment;
        HeatTotal = DefaultHeat;

        StartCoroutine(ElapseSecond());

    }

    IEnumerator ElapseSecond()
    {
        yield return new WaitForSeconds(1.0f); //Every second, increment this and restart the coroutine.
        //PSUEDO: Change the color of the bar depending on the level of heat/resource etc.
        //PSUEDO: Trigger alarm sounds based on the levels.

        if (WaterTotal > 0.0f)
            WaterTotal -= WaterDecayPerSecond;                   //Decrement Water
        else
            HealthTotal -= 0.05f;
        if (EntertainmentTotal > 0.0f)
            EntertainmentTotal -= EntertainmentDecayPerSecond;   //Decrement Ent
        else
            HealthTotal -= 0.05f;

        if (FoodTotal <= 0.0f)
        {
            FoodTotal = 0.0f;
            HealthTotal -= 0.05f;
        }else
        {
            FoodTotal -= FoodDecayPerSecond;                     //Decrement Food
        }

        if (HeatTotal > 0.0f)
            HeatTotal -= HeatIncrementPerSecond;                 //Increment the heat per second.
        else
        {
            HealthTotal -= 0.05f;
        }

        if (HealthTotal < 0.0f)
        {
            GameObject runTotalToken = new GameObject();
            runTotalToken.name = "RunningTotalToken";
            runTotalToken.AddComponent<RunningTotalToken>();
            runTotalToken.GetComponent<RunningTotalToken>().SyncActions(GameObject.Find("PlayerCharacter").GetComponent<ActivityList>().MasterList);
            SceneManager.LoadScene(3); //3rd scene in build order is game over.
        }

        //Cap resource gain at 1.0f

        if (HeatTotal > 1.0f)   
            HeatTotal = 1.0f;
        if (WaterTotal > 1.0f)
            WaterTotal = 1.0f;
        if (EntertainmentTotal > 1.0f)
            EntertainmentTotal = 1.0f;
        if (FoodTotal > 1.0f)
            FoodTotal = 1.0f;

        HeatBarFill.SetFillBar(HeatTotal);                   //Set the fill bar 

        StartCoroutine(ElapseSecond());
    }

    void Update()
    {
        FoodBarFill.SetFillBar(FoodTotal);
        WaterBarFill.SetFillBar(WaterTotal);
        EntBarFill.SetFillBar(EntertainmentTotal);
        HealthBarFill.SetFillBar(HealthTotal);
    }
}
