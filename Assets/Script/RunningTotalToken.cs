using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningTotalToken : MonoBehaviour
{
    public List<ActivityList.Activity> fullActions;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void SyncActions(List<ActivityList.Activity> SourceActionList)
    {
        fullActions = SourceActionList;
    }
}
