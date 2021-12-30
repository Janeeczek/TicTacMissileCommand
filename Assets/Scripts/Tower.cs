using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int health = 3;
    private void OnCollisionEnter2D(Collision2D col)
    {
        switch (health)
        {
            case 3:
                gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",Color.yellow);
                health--;
                break;
            case 2:
                gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",Color.red);
                health--;
                break;
            case 1:
                Destroy(gameObject);
                GameLogic.TowersAlive--;
                break;
            default:
                break;
        }
    }
}
