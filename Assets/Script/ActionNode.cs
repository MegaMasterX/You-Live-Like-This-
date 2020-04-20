using UnityEngine;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine.InputSystem;

[RequireComponent(typeof(BoxCollider2D))]
public class ActionNode : MonoBehaviour
{

    [BoxGroup("Action")]
    public Action thisAction;

    [BoxGroup("Action")]
    public Action.StatType StatBoostType;              //This determines the stat that is increased by turning in this Action.
    [BoxGroup("Action")]
    public Action.ActionType ThisActionMode;           //The Action Mode determines what exactly this resource node is intending to do.
    [BoxGroup("Action"), ShowIf("ThisActionMode", Action.ActionType.CallForHelp)]
    public float Cooldown;                      //This is to be used for the CallForHelp ActionType if there's a cooldown to be configured.        
    [BoxGroup("Action"), ShowIf("ThisActionMode", Action.ActionType.PickupNodeOneHand)]
    public float NodeAmount;                    //This dictates how much this node should add to the current running total.


    [ReadOnly,BoxGroup("Action")]
    public bool PlayerInRange = false;              //Is the player in the hitbox for this node?

    [BoxGroup("Activity Details"), ShowIf("ThisActionMode", Action.ActionType.PickupNodeOneHand)]
    public string ActivityName;
    [BoxGroup("Activity Details"), ShowIf("ThisActionMode", Action.ActionType.PickupNodeOneHand)]
    public float ActivityCost;

    MasterInput pInput;
    GameObject PlayerObject;

    HeldActions pHeldActions;
    ResourceManager rMgr;
    ActivityList pActList;

    void Start()
    {
        pInput = new MasterInput();                 //Hook into the Input System.
        pInput.InGame.Interact.performed += HandleConfirm; //Hook into the Confirm button config.
        pInput.Enable();                            //Enable the Player Input.
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
        pHeldActions = PlayerObject.GetComponent<HeldActions>();
        rMgr = GameObject.FindGameObjectWithTag("ResourceScreen").GetComponent<ResourceManager>();
        pActList = GameObject.FindGameObjectWithTag("Player").GetComponent<ActivityList>();
    }

    /// <summary>
    /// This void is for hooking into the Input system and handles pressing the South button (X or A or Space)
    /// </summary>
    /// <param name="ctx"></param>
    void HandleConfirm(InputAction.CallbackContext ctx)
    {
        if (PlayerInRange)
        {
            switch (ThisActionMode)
            {
                case Action.ActionType.PickupNodeOneHand:
                    if (pHeldActions.heldAction == null)
                    {
                        Action newAction = new Action();
                        newAction.ThisActionMode = ThisActionMode;
                        newAction.StatBoostType = StatBoostType;
                        if (NodeAmount != 0.0f)
                            newAction.NodeAmount = NodeAmount;
                        newAction.ActionName = ActivityName;
                        newAction.ActionCost = ActivityCost;
                        
                        pHeldActions.heldAction = newAction;
                        Debug.Log("Added an Action to the player's held action.");

                        if (StatBoostType == Action.StatType.Entertainment)
                        {
                            GameObject.Find("Loudspeaker").GetComponent<Loudspeaker>().PlayRandomToyVO();
                            //GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.BottleWater;
                        }
                        
                        if (StatBoostType == Action.StatType.Heat)
                        {
                            GameObject.Find("Loudspeaker").GetComponent<Loudspeaker>().PlayRandomWoodVO();
                            GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.Wood;
                        }
                            
                        if (StatBoostType == Action.StatType.Water)
                        {
                            GameObject.Find("Loudspeaker").GetComponent<Loudspeaker>().PlayRandomWaterVO();
                            GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.BottleWater;
                        }
                            
                        
                    }
                    
                    break;
                case Action.ActionType.DepositNode:                //The node that the player is interacting with is a Deposit node.
                    if (pHeldActions.heldAction != null)
                    {
                        if (pHeldActions.heldAction.StatBoostType == StatBoostType)
                        {
                            DepositValue();
                            pHeldActions.heldAction = null; //clear the action.
                        }
                    }
                    break;
                case Action.ActionType.CallForHelp:
                    //PSUEDO: Check to see if the cooldown has elapsed.
                    break;
                case Action.ActionType.TrashCan:
                    //PSUEDO: Add the player's currently held action to the current score total for the memes
                    //PSUEDO: Clear out the player's held item.
                    break;
                case Action.ActionType.HoldBucketEmpty:
                    if (pHeldActions.heldAction != null)
                    {
                        Action newAction = new Action();
                        newAction.ThisActionMode = Action.ActionType.HoldBucketEmpty;
                        
                    }
                    break;
                case Action.ActionType.HoldBucketFull:
                    if (pHeldActions.heldAction != null)
                    {
                        Action newAction = new Action();
                        newAction.ThisActionMode = Action.ActionType.HoldBucketFull;
                        if (NodeAmount != 0.0f)
                            newAction.NodeAmount = NodeAmount;
                        newAction.StatBoostType = Action.StatType.Food; //EAT YOUR FEED
                        newAction.ActionName = "Bucket of Chili";
                        newAction.ActionCost = 20.0f; //$20 for a bucket of chili is either a great deal or highway robbery
                        pHeldActions.heldAction = newAction;
                    }
                    break;
                default:
                    break;
            }
        }
    }

    /// <summary>
    /// This removes the held item from the player's character and deposits it into the monster machine.
    /// </summary>
    public void DepositValue()
    {
        //This will need to be where the audio clips are played from.
        //PSUEDO: Add a check to see if the resource value can even be added to begin with.
        switch (pHeldActions.heldAction.StatBoostType)
        {
            case Action.StatType.Food:
                rMgr.FoodTotal += pHeldActions.heldAction.NodeAmount;
                pActList.AddActivity(pHeldActions.heldAction.ActionName, pHeldActions.heldAction.ActionCost);
                GameObject.Find("Bucket_AtClient").GetComponent<BucketTrigger>().IsTriggerActive = true; //The bucket can be picked up by the player.
                GameObject.Find("Field Objects").GetComponent<BucketManager>().AtPipe = false;
                GameObject.Find("Field Objects").GetComponent<BucketManager>().InPlayerPosession = false;
                GameObject.Find("Field Objects").GetComponent<BucketManager>().AtClient = true; //The bucket is at the client.
                GameObject.Find("AudioManager").GetComponent<AudioManager>().PlayFullDrop();
                Debug.Log("Trigger [CLIENT]: Bucket placed at Client.");
                GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.Empty;
                GameObject.Find("Reboot Trigger").GetComponent<RebootManager>().RandomBSODChanceTrigger();
                break;
            case Action.StatType.Water:
                rMgr.WaterTotal += pHeldActions.heldAction.NodeAmount;
                pActList.AddActivity(pHeldActions.heldAction.ActionName, pHeldActions.heldAction.ActionCost);
                //PSUEDO: Set HUD_Held.
                GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.Empty;
                Debug.Log($"Adding Water: {pHeldActions.heldAction.NodeAmount.ToString()}");
                break;
            case Action.StatType.Entertainment:
                rMgr.EntertainmentTotal += pHeldActions.heldAction.NodeAmount;
                pActList.AddActivity(pHeldActions.heldAction.ActionName, pHeldActions.heldAction.ActionCost);
                GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.Empty;
                GameObject.Find("Reboot Trigger").GetComponent<RebootManager>().RandomBSODChanceTrigger();
                break;
            case Action.StatType.Heat:
                rMgr.HeatTotal += pHeldActions.heldAction.NodeAmount;
                pActList.AddActivity(pHeldActions.heldAction.ActionName, pHeldActions.heldAction.ActionCost);
                GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.Empty;
                GameObject.Find("Reboot Trigger").GetComponent<RebootManager>().RandomBSODChanceTrigger();
                break;
            
            default:
                break;
        }

        pHeldActions.heldAction = null;
    }

    void OnTriggerEnter2D()
    {
        PlayerInRange = true;
    }

    void OnTriggerExit2D()
    {
        PlayerInRange = false;  
    }

    void OnDisable()
    {
        pInput.Disable();                           //Shut down the Input hook on disable.
    }

   
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
        TrashCan
    }
}
