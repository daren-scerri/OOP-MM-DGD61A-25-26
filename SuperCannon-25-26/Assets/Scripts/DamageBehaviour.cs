using UnityEngine;
using static Enemy;

public class DamageBehaviour : MonoBehaviour, ITakeDamage
{
    Enemy _enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _enemy = GetComponent<Enemy>();
    }

    public void ApplyDamage(int hitpoints)
    {
        if (hitpoints > 0)
        {
            GameData.Score += hitpoints;
            Debug.Log("Score: " + GameData.Score.ToString());
        }

        _enemy.health--;
        Debug.Log("Enemy health: " + _enemy.health.ToString());
        if (_enemy.health <= 0)
        {         
            Destroy(this.gameObject);
        }


    }


}
