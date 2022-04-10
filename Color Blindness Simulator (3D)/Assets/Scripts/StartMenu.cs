using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartMenu : MonoBehaviour
{
    // sets default to having the menu open
    public bool GameIsPaused = false;
    public Button StartButton;
    public GameObject GameStartUI;



    void Start()
    {
        Intro();
    }

    void StartGame()
    {
        GameStartUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Intro()
    {
        GameStartUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void On_Start_Button_Click()
    {
        Debug.Log("Game is Go!");
        StartGame();
    }
}
