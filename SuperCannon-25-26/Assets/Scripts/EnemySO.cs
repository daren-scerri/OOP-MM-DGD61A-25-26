using UnityEngine;

[CreateAssetMenu(fileName = "EnemySO", menuName = "Scriptable Objects/EnemySO")]
public class EnemySO : ScriptableObject
{
    public GameObject enemyPrefab;
    public int health;
    public int hitpoints;
    public float speed;
}
