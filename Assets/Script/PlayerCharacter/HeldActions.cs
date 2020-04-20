using UnityEngine;
using System.Collections;
using Sirenix.OdinInspector;

/// <summary>
/// This script is for maintaining the player's currently held actions.
/// </summary>
public class HeldActions : MonoBehaviour
{
    public Action heldAction;           //Currently held Action.
    public Action.ActionType thisType;  //Quickly referrable ActionType.

    public bool FullBucket = false;
   
}
