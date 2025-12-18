using UnityEngine;
using static Enemy;

public class NewMonoBehaviourScript : MonoBehaviour, ITakeDamage
{
    public void ApplyDamage()
    {
        Destroy(this.gameObject);
    }
}
