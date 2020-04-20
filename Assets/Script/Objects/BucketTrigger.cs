using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class BucketTrigger : MonoBehaviour
{
    bool IsPlayerInRange = false;

    MasterInput mInput;

    public bool IsTriggerActive = false;
    public Position thisTriggerPosition;

    BucketManager bMgr;
    HeldActions pHeldAction;

    void Start()
    {
        mInput = new MasterInput();
        mInput.InGame.Interact.performed += HandleConfirm;
        mInput.Enable();
        pHeldAction = GameObject.FindGameObjectWithTag("Player").GetComponent<HeldActions>();
        bMgr = GameObject.Find("Field Objects").GetComponent<BucketManager>();
    }

    void HandleConfirm(InputAction.CallbackContext ctx)
    {
        if (IsTriggerActive && thisTriggerPosition == Position.Client && IsPlayerInRange)
        {
            //The bucket is at the client and is active. 
            bMgr.InPlayerPosession = true; //This will hide both buckets in the field.
            bMgr.AtPipe = false;
            bMgr.AtClient = false;
            IsTriggerActive = false; //The bucket can't be picked up again.
            GameObject.Find("AudioManager").GetComponent<AudioManager>().PlayEmptyPickup();
            GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.BucketEmpty;
            GameObject.Find("BucketPlace").GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, 64.0f); //Enable the bucket.
        }

        if (IsTriggerActive == false && bMgr.InPlayerPosession == true && thisTriggerPosition == Position.Pipe && IsPlayerInRange) //Is the empty bucket in the player posession?
        {
            bMgr.InPlayerPosession = false; //The bucket has been dropped.
            bMgr.AtPipe = true; //The bucket is at the pipe.
            GameObject.Find("BucketPlace").GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, 0.0f); //Enable the bucket.
            GameObject.Find("AudioManager").GetComponent<AudioManager>().PlayEmptyDrop();
            GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.Empty;

        }

        if (IsTriggerActive && thisTriggerPosition == Position.Pipe && IsPlayerInRange)
        {
            //The bucket was filled and can be picked up by the player.
            IsTriggerActive = false; //The bucket can't be picked up again.
            bMgr.AtPipe = false;
            bMgr.InPlayerPosession = true;
            Action nAction = new Action();
            nAction.ActionCost = 30.0f;
            nAction.ActionName = "Bucket of Chili";
            nAction.NodeAmount = 0.3f;
            nAction.StatBoostType = Action.StatType.Food;
            pHeldAction.heldAction = nAction;
            GetComponent<Animator>().SetTrigger("Empty");
            GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, 0.0f);
            GameObject.Find("Loudspeaker").GetComponent<Loudspeaker>().PlayRandomChiliVO();
            GameObject.Find("AudioManager").GetComponent<AudioManager>().PlayFullPickup();
            GameObject.Find("HUD_Held").GetComponent<HeldHUD>().ShownHUD = HeldHUD.HUDElement.BucketFull;
        }

    }

    void Update()
    {

    }

    void OnTriggerEnter2D()
    {
        IsPlayerInRange = true;
    }

    void OnTriggerExit2D()
    {
        IsPlayerInRange = false;
    }

    void OnDisable()
    {
        mInput.Disable();
    }

    public enum Position
    {
        Client,
        Pipe
    }
}
