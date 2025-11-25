using UnityEngine;

public class SmallBullet : DefaultBullet
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        rb.gravityScale = 0;
    }


}
