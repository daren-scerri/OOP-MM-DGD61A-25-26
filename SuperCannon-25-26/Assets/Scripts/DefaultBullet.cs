using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class DefaultBullet : MonoBehaviour
{
    [SerializeField] private float defaultPush = 1f;
    [SerializeField] public float firingRate;


    protected Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        gameObject.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    protected virtual void Start()
    {
     
    }

    protected virtual bool GetDestroyCondition()
    {
        bool destroy = false;
       
        float bulletX = this.transform.position.x;
        float bulletY = this.transform.position.y;

        destroy = destroy || (
            bulletX < GameData.XMin
        || bulletX > GameData.XMax
        || bulletY < GameData.YMin
        || bulletY > GameData.YMax
        );

        return destroy;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (GetDestroyCondition())
        {
            this.gameObject.SetActive(false);
            rb.linearVelocity = new Vector2(0, 0);
            this.gameObject.transform.position = new Vector3(0f,0f,0f);
            this.gameObject.transform.rotation = Quaternion.identity;
        }
    }

    public void Shoot(Vector3 from, Quaternion dirRot)
    {
        gameObject.SetActive(true);
        transform.position = from;
        transform.rotation = dirRot;
        rb.linearVelocity = transform.up * defaultPush;
    }
}