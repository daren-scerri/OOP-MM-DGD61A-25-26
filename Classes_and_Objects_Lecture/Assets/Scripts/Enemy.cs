using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy :MonoBehaviour
{
    public int hitpoints, damage;
    public Vector3 position;
    public string name;
    public GameObject enemyPrefab;
    GameObject _gameObject;
    public Enemy(int hp, int dmg, string ID, GameObject _enemyPrefab, Vector3 _position)
    {
        hitpoints = hp;
        damage = dmg;
        name = ID;
        enemyPrefab = _enemyPrefab;
        position = _position;
        _gameObject = Instantiate(enemyPrefab, position, Quaternion.identity);
    }

    public void TakeDamage()
    {
        hitpoints--;
        Debug.Log(name + "'s HP:" + hitpoints);
    }

    public void Die()
    {
        Debug.Log(name + " has died");
        Destroy(_gameObject);
    }
}
