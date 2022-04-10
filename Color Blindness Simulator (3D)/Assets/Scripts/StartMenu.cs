using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class StartMenu : MonoBehaviour
{
    public Button StartButton;
    public GameObject gameStartUI;
    public GameObject gameUI;



    void Start()
    {
        Intro();
    }

    void StartGame()
    {
        gameStartUI.SetActive(false);
        gameUI.SetActive(true);
    }

    void Intro()
    {
        gameStartUI.SetActive(true);
        gameUI.SetActive(false);
    }

    public void On_Start_Button_Click()
    {
        Debug.Log("Game is Go!");
        StartGame();
    }
}
