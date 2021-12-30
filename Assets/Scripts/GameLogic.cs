using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public static int TowersAlive = 4;
    [SerializeField] private Text scoreUI;
    
    private void Update()
    {
        if (TowersAlive < 1)
        {
            GameManager.GameOver();
        }

        if (!scoreUI.text.Equals(GameManager.Score.ToString()))
        {
            UpdateScoreUI();
        }
    }
    
    public static void AddScore()
    {
        GameManager.Score += 100;
    }
    private  void UpdateScoreUI()
    {
        scoreUI.text = GameManager.Score.ToString();
    }

    
}
