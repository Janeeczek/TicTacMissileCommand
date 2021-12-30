using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MovingObject
{
    protected override void OnCollisionEnter2D(Collision2D col)
    {
        base.OnCollisionEnter2D(col);
        GameLogic.AddScore();
    }
}
