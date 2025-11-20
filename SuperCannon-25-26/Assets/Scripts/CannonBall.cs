
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CannonBall : DefaultBullet
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        rb.gravityScale = 1;
    }

    protected override bool GetDestroyCondition()
    {
     // tuple(xmin, xmax, ymin, ymax)
        bool destroycondition = false;
        if (transform.position.y < GameData.YMin) { destroycondition = true; }
        return destroycondition; // Due to gravity, let the cannonball fall below bottom of screen before destroying
    }
}

