using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action
{

    public StatType StatBoostType;              //This determines the stat that is increased by turning in this Action.
    public ActionType ThisActionMode;           //The Action Mode determines what exactly this resource node is intending to do.
    public float Cooldown;                      //This is to be used for the CallForHelp ActionType if there's a cooldown to be configured.        
    public float NodeAmount;                    //This is the amount of resource that is added when the action is deposited.

    public string ActionName;
    public float ActionCost;
    public enum StatType
    {
        Nothing,
        Food,
        Water,
        Entertainment,
        Heat
    }
    public enum ActionType
    {
        PickupNodeOneHand,
        PickupNodeTwoHand,
        DepositNode,
        ActionNode,
        CallForHelp,
        TrashCan,
        HoldBucketEmpty,
        HoldBucketFull
    }

}
