using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingObject : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject,15f);
    }
    protected virtual void OnTriggerExit2D(Collider2D col)
    {
        Destroy(gameObject);
        
    }
    protected virtual void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }
}
