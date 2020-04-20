using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
public class RebootManager : MonoBehaviour
{
    public int BSODCountdown = 0;
    Animator screenAnimator;
    PlayerController pController;
    MasterInput mInput;
    ResourceManager rMgr;

    public bool BSODActive = false;
    bool IsPlayerInRange = false;

    void Start()
    {
        BSODCountdown = Random.Range(90, 150); //Reset the countdown with a minimum of 3 minutes and a maximum of 10 minutes.
        screenAnimator = GameObject.Find("ScreenOverlay").GetComponent<Animator>();
        pController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        rMgr = GameObject.Find("IndicatorScreen").GetComponent<ResourceManager>();
        mInput = new MasterInput();
        mInput.InGame.Interact.performed += HandleConfirm;
        mInput.Enable();
        StartCoroutine(CountdownTick());
    }

    void HandleConfirm(InputAction.CallbackContext ctx)
    {
        if (IsPlayerInRange && BSODActive)
        {
            pController.MovementEnabled = false; //Disable the player's movement until the reboot sequence completes, which is handled by the animator.
            screenAnimator.SetTrigger("Reboot"); //Send the reboot signal and roll that beautiful bean footage.
            GameObject.Find("AudioManager").GetComponent<AudioManager>().PlayKeyboardTyping();
        }
    }

    public void RandomBSODChanceTrigger()
    {
        int RandomChance = Random.Range(1, 100);
        if (RandomChance > 15 && RandomChance < 30)
        {
            if (BSODActive == false) //This should be dictated by the status of the current BSOD and not some unreliable variable. 
            {
                GameObject.Find("Loudspeaker").GetComponent<Loudspeaker>().PlayRandomComputerVO();
                BSODActive = true;                      //Logic trigger.
                screenAnimator.SetTrigger("BSOD");      //Fire up the BSOD animation on the screen.
                rMgr.SFXEnabled = false;                //Disable the SFX for the resource ticker.
                
            }            
        }

    }

    public void ResetBSODCountdown()
    {
        BSODCountdown = Random.Range(45, 150);
        BSODActive = false;

    }

    IEnumerator CountdownTick()
    {
        yield return new WaitForSeconds(1.0f);
        if (BSODCountdown != 0 && BSODActive == false)
        {
            BSODCountdown--;
        }
        else if (BSODCountdown == 0 && BSODActive == false)
        {
            GameObject.Find("Loudspeaker").GetComponent<Loudspeaker>().PlayRandomComputerVO();
            BSODActive = true;                      //Logic trigger.
            screenAnimator.SetTrigger("BSOD");      //Fire up the BSOD animation on the screen.
            rMgr.SFXEnabled = false;                //Disable the SFX for the resource ticker.
        }
        StartCoroutine(CountdownTick());
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
}
