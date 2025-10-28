using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy :MonoBehaviour
{
    private int _hitpoints, _damage;
    private Vector3 _position;
    private string _name;
    private GameObject _enemyPrefab;
    private GameObject _gameObject;
    public Enemy(int hp, int dmg, string ID, GameObject enemyPrefab, Vector3 position)
    {
        _hitpoints = hp;
        _damage = dmg;
        _name = ID;
        _enemyPrefab = enemyPrefab;
        _position = position;
        _gameObject = Instantiate(enemyPrefab, _position, Quaternion.identity);
    }

    public int Hitpoints   //public getter (read-only)
    {  
        get { return _hitpoints; } 
    }

    public int Damage   //public getter (read-only)
    {
        get { return _damage; }
    }

    public string EnemyName   //public getter (read-only)
    {
        get { return _name; }
    }

    public void TakeDamage()
    {
        _hitpoints--;
        Color currentColor = _gameObject.GetComponent<SpriteRenderer>().color;
        Color newColor = currentColor - new Color(0f, 0.1f, 0.1f, 0f); 
        _gameObject.GetComponent<SpriteRenderer>().color = newColor;
        Debug.Log(_name + "'s HP:" + _hitpoints);
    }

    public void Die()
    {
        Debug.Log(_name + " has died");
        Destroy(_gameObject);
    }
}
