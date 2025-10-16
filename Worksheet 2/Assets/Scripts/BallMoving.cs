using UnityEngine;

public class BallMoving : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(100f, 120f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
