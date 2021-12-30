using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public static int Score;


    private static GameManager _gameManagerInstance;
    public static void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        Score = 0;
    }
    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public static void Pause()
    {
        Time.timeScale = 0;
    }
    public static void UnPause()
    {
        Time.timeScale = 1;
    }
    public static void Quit()
    {
        Application.Quit();
    }
    void Awake() 
    {
        if (_gameManagerInstance == null)
        {
            DontDestroyOnLoad(gameObject);
            _gameManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
