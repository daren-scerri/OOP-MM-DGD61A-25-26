using UnityEngine;

//[RequireComponent (typeof(FireUp))]
public class BulletControl : MonoBehaviour
{
   

    Rigidbody2D rb;
    FireUp gunfire;
    Projectile myprojectile;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        gunfire = GetComponent<FireUp>();
       // gunfire.YForce = 200f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) 
        {
            if (gunfire != null) gunfire.Fire(rb);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
