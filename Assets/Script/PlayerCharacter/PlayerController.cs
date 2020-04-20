using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Sirenix.OdinInspector;
public class PlayerController : MonoBehaviour
{
    [BoxGroup("Movement")]
    public float speed;

    [BoxGroup("Movement")]
    public bool MovementEnabled = true;

//    [BoxGroup("Live Data")]


    private Vector2 movement;

    public Animator pAnimator;
    Vector2 movementInput;
    MasterInput inputActions;

    void Start()
    {
        inputActions = new MasterInput(); //Set up the input configuration profile.
        inputActions.InGame.Character.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        inputActions.InGame.Character.canceled += ctx => movementInput = Vector2.zero;
        inputActions.InGame.Interact.performed += HandleConfirm;
        inputActions.InGame.CloseGame.performed += HandleQuit;

        inputActions.Enable();

        pAnimator = GetComponent<Animator>();
    }

    void HandleConfirm(InputAction.CallbackContext ctx)
    {

    }

    void HandleQuit(InputAction.CallbackContext ctx)
    {

    }

    void Update()
    {
        if (MovementEnabled == true)
        {
            playerMoving = false;

            float inputX = movementInput.x;
            float inputY = movementInput.y;

            pAnimator.SetFloat("MoveX", inputX);
            pAnimator.SetFloat("MoveY", inputY);

            if (inputX != 0.0f)
            {
                playerMoving = true;
                lastMove = new Vector2(inputX, inputY);
            }
                
            
            if (inputY != 0.0f)
            {
                playerMoving = true;
                lastMove = new Vector2(inputX, inputY);
            }

            pAnimator.SetFloat("LastMoveX", lastMove.x);
            pAnimator.SetFloat("LastMoveY", lastMove.y);
            pAnimator.SetBool("PlayerMoving", playerMoving);

            movement = new Vector2(inputX, inputY);
            transform.Translate(movement * speed * Time.deltaTime);

        }
    }

    private bool playerMoving;
    private Vector2 lastMove;
    
    private void OnDisable()
    {
        inputActions.Disable();
    }
}
