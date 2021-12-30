using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text scoreUI;
    void Start()
    {
        scoreUI.text = GameManager.Score.ToString();
    }
}
