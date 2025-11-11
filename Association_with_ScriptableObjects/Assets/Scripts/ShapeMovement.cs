using UnityEngine;

public class ShapeMovement : MonoBehaviour
{
    public KeyCode my_keycode;

    Rigidbody2D rb;
    float new_Xvelocity, new_Yvelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(my_keycode))
        {
            new_Xvelocity = Random.Range(-10f, +10f);
            new_Yvelocity = Random.Range(-10f, +10f);
            rb.linearVelocity = new Vector2(new_Xvelocity, new_Yvelocity);
        }
    }
}
