using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class IntroSkip : MonoBehaviour
{
    MasterInput mInput;
    void Start()
    {
        mInput = new MasterInput();
        mInput.UI_Menu.Confirm.performed += HandleConfirm;
        mInput.Enable();
    }

    void HandleConfirm(InputAction.CallbackContext ctx)
    {
        SceneManager.LoadScene(2); //Skip that shit, start the game.
    }

    void OnDisable()
    {
        mInput.Disable();
    }

}
