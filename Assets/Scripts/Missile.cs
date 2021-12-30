using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MovingObject
{
    public GameObject explosionObj;
    
    protected override void OnCollisionEnter2D(Collision2D col)
    {
        base.OnCollisionEnter2D(col);
        Instantiate(explosionObj,transform.position,transform.rotation);
    }
}
