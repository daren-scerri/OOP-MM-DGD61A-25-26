using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health;
    public int hitpoints;
    public float speed;

    public interface ITakeDamage
    {
        public void ApplyDamage(int hitpoints); 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (this.gameObject.transform.position.y < GameData.YMin)
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            other.gameObject.SetActive(false);
            GetComponent<ITakeDamage>().ApplyDamage(hitpoints);   //to supply hitpoints as parameter
            GameManager.Instance.DisplayScore();
        }

        if (other.gameObject.name.Contains("PlayerBase"))
        {
           EnemyWins();
        }
    }

    private void EnemyWins()
    {
        GameData.PlayerHealth -= 1;
        GameManager.Instance.DisplayHealth();
        Debug.Log("Player health: " + GameData.PlayerHealth.ToString());
        Destroy(this.gameObject);
    }

}
