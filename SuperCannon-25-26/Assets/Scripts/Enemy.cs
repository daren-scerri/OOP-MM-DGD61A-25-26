using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int strength;
    public int hitpoints;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y < GameData.YMin)
        {
            Destroy(this.gameObject);
        }
    }
}
