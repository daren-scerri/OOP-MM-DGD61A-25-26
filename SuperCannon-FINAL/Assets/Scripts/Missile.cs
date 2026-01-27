using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : DefaultBullet
{
    protected override void Start()
    {
        base.Start();
        rb.linearDamping = 0.5f;
        rb.gravityScale = 0f;
    }

}
