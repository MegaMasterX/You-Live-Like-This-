using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSODRebootBehavior : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject.Find("PlayerCharacter").GetComponent<PlayerController>().MovementEnabled = true;
        GameObject.Find("IndicatorScreen").GetComponent<ResourceManager>().SFXEnabled = true;
        GameObject.Find("Reboot Trigger").GetComponent<RebootManager>().ResetBSODCountdown();
        //PSUEDO: Randomize the decay values.
        float HeatDecayValue = (Random.Range(1, 3) * 0.01f);
        float FoodDecayValue = (Random.Range(5, 9) * 0.001f);
        float WaterDecayValue = (Random.Range(3, 9) * 0.001f);
        float EntDecayValue = (Random.Range(3, 8) * 0.001f);

        ResourceManager rM = GameObject.Find("IndicatorScreen").GetComponent<ResourceManager>();
        rM.HeatIncrementPerSecond = HeatDecayValue;
        rM.FoodDecayPerSecond = FoodDecayValue;
        rM.WaterDecayPerSecond = WaterDecayValue;
        rM.EntertainmentDecayPerSecond = EntDecayValue;
    }

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
