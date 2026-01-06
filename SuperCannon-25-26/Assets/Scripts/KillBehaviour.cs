using UnityEngine;
using static Enemy;

public class KillBehaviour : MonoBehaviour, ITakeDamage
{
    public void ApplyDamage(int hitpoints)
    {
        if (hitpoints > 0) GameData.Score += hitpoints;
        Debug.Log("Score: " + GameData.Score.ToString());
        Destroy(this.gameObject);
    }
}
