using UnityEngine;

public class Enemy 
{
    public int hitpoints, damage;
    public string name;

    public Enemy(int hp, int dmg, string ID)
    {
        hitpoints = hp;
        damage = dmg;
        name = ID;
    }

    public void TakeDamage()
    {
        hitpoints--;
        Debug.Log(name + "'s HP:" + hitpoints);
    }

    public void Die()
    {
        Debug.Log(name + " has died");
    }
}
