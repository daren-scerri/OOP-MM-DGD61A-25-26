using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int strength;
    public int hitpoints;
    public float speed;

    public interface ITakeDamage
    {
        public void ApplyDamage(); //to add hitpoints as parameter
    }

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


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            GetComponent<ITakeDamage>().ApplyDamage();   //to supply hitpoints as parameter
        }

        //if (other.gameObject.name.Contains("PlayerBase"))
        //{
         //   EnemyWins();
        //}
    }

}
