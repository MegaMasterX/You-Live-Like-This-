using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilledBehavior : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject.Find("ChiliSwitch").GetComponent<ChiliSwitch>().FlipSwitchOff();
        GameObject.Find("ChiliSwitch").GetComponent<ChiliSwitch>().BucketFilling = false; //The bucket has been filled.
        GameObject.Find("Field Objects").GetComponent<BucketManager>().BucketAtPipeFull = true;
        GameObject.Find("Bucket_AtPipe").GetComponent<BucketTrigger>().IsTriggerActive = true; //Enable the player pickup.
        Debug.Log("Animation [PIPE]: Bucket filled at pipe. Pickup enabled.");

        //PSUEDO: Play Click SFX
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
