using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void QuitPressed()
    {
        GameManager.Quit();
    }
    public void PlayPressed()
    {
        GameManager.StartGame();
    }
}
