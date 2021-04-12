using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public GameObject ButtonQuit;

    void Start()
    {
        ButtonQuit.SetActive(false);
    }

    public void RevealQuitButton()
    {
        ButtonQuit.SetActive(true);
    }

    public void OnClick()
    {
        print("You Have Quit the Game!");

        Application.Quit();
    }
}
