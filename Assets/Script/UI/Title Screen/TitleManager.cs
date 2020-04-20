using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class TitleManager : MonoBehaviour
{
    MasterInput mInput;
    public bool ConfirmEnable = false;
    void Start()
    {
        mInput = new MasterInput();
        mInput.UI_Menu.Confirm.performed += HandleConfirm;
        mInput.Enable();
    }

    void HandleConfirm(InputAction.CallbackContext ctx)
    {
        if (ConfirmEnable)
        {
            SceneManager.LoadScene(1); //Load the tutorial scene.
        }
    }

    void OnDisable()
    {
        mInput.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
