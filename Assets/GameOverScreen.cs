using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    MasterInput mInput;
    int MenuIndex = 0;

    public CanvasGroup btn1;
    public CanvasGroup btn2;

    Text TotalText;
    List<ActivityList.Activity> TotalActions;
    double RunningTotal;

    public AudioClip Lose1;
    public AudioClip Lose2;
    public AudioClip Lose3;
    public AudioClip Lose4;
    public AudioClip Lose5;


    void Start()
    {
        mInput = new MasterInput();
        mInput.UI_Menu.Confirm.performed += HandleConfirm;
        mInput.UI_Menu.Up.performed += HandleUp;
        mInput.UI_Menu.Down.performed += HandleDown;
        mInput.Enable();
        TotalText = GameObject.Find("RunningTotal").GetComponent<Text>();
        PlayRandomGameOverVO(GetComponent<AudioSource>());
        TotalActions = GameObject.Find("RunningTotalToken").GetComponent<RunningTotalToken>().fullActions;
        //PSUEDO: Get the "Running Total" object and pull the list down from it.
        PopulateBill();
 

        
    }

    void PlayRandomGameOverVO(AudioSource src)
    {
        int Quoteint = Random.Range(1, 5);
        switch (Quoteint)
        {
            case 1:
                src.clip = Lose1;
                src.Play();
                break;
            case 2:
                src.clip = Lose2;
                src.Play();
                break;
            case 3:
                src.clip = Lose3;
                src.Play();
                break;
            case 4:
                src.clip = Lose4;
                src.Play();
                break;
            case 5:
                src.clip = Lose5;
                src.Play();
                break;
            default:
                break;
        }
    }

    void PopulateBill()
    {
        for (int i = 0; i < TotalActions.Count; i++)
        {
            TotalText.text += $"- {TotalActions[i].ActivityName} - ${TotalActions[i].ActivityCost.ToString()}\n";
            RunningTotal += TotalActions[i].ActivityCost;
        }
        TotalText.text += $"\nTotal: ${RunningTotal.ToString()}";
        GameObject.Destroy(GameObject.Find("RunningTotalToken")); //Destroy the token in case the player decides to restart the game.
        //PSUEDO: Save the total if its the highest??
    }
    
    void HandleConfirm(InputAction.CallbackContext ctx)
    {
        if (MenuIndex == 0)
            SceneManager.LoadScene(2);
        if (MenuIndex == 1)
            Application.Quit();
    }


    void HandleDown(InputAction.CallbackContext ctx)
    {
        if (MenuIndex == 1)
            MenuIndex = 0;
        else
            MenuIndex = 1;

    }

    void HandleUp(InputAction.CallbackContext ctx)
    {
        if (MenuIndex == 0)
            MenuIndex = 1;
        else
            MenuIndex = 0;

    }

    void Update()
    {
        if (MenuIndex == 0)
        {
            btn1.alpha = 1;
            btn2.alpha = 0;
        }else
        {
            btn1.alpha = 0;
            btn2.alpha = 1;
        }
    }

    void OnDisable()
    {
        mInput.Disable();
    }
}
