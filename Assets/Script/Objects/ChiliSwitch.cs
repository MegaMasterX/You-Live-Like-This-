using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class ChiliSwitch : MonoBehaviour
{
    public bool IsPlayerInRange = false;
    public bool BucketFilling;

    public GameObject Bucket;

    MasterInput mInput;

    public Sprite OffSwitch;
    public Sprite OnSwitch;

    Animator pipeAnimator;
    Animator BucketAnimator;

    void Start()
    {
        mInput = new MasterInput();
        mInput.InGame.Interact.performed += HandleConfirm;
        mInput.Enable();
        pipeAnimator = GameObject.Find("Pipe").GetComponent<Animator>();
        BucketAnimator = Bucket.GetComponent<Animator>();
    }

    public void FlipSwitchOn()
    {
        BucketFilling = true;
        GetComponent<SpriteRenderer>().sprite = OnSwitch;
        BucketAnimator.SetTrigger("Fill");
    }

    public void FlipSwitchOff()
    {
        GetComponent<SpriteRenderer>().sprite = OffSwitch;

    }

    void HandleConfirm(InputAction.CallbackContext ctx)
    {
        if (IsPlayerInRange)
        {
            if (GameObject.Find("Field Objects").GetComponent<BucketManager>().AtPipe == true)
            {
                if (BucketFilling == false)
                    FlipSwitchOn();

            }else
            {
                //PSUEDO: Play rejection sound.
            }
            //PSUEDO: Check to see if the bucket of chili is placed below the pipe. If not, play the voice clip saying so.
            //PSUEDO: Else

        }
    }

    void OnTriggerEnter2D()
    {
        IsPlayerInRange = true;
    }

    void OnTriggerExit2D()
    {
        IsPlayerInRange = false;
    }
    
 
}
