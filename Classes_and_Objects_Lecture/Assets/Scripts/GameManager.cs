using UnityEngine;

public class GameManager : MonoBehaviour
{
    Enemy bob, alice;
    int playerHP = 10;
    public GameObject Enemy1, Enemy2;
    public int hitpoints_Enemy1, hitpoints_Enemy2, damage_Enemy1, damage_Enemy2;
    void Start()
    {
        bob = new Enemy(hitpoints_Enemy1, damage_Enemy1, "Bob", Enemy1, new Vector3(-4f,0f,0f));
        Debug.Log(bob.EnemyName + " is born");
        alice = new Enemy(hitpoints_Enemy2, damage_Enemy2, "Alice", Enemy2, new Vector3(+4f, 0f, 0f));
        Debug.Log(alice.EnemyName + " is born");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //Bob takes damage if Spacebar is pressed
            bob.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftShift))
            //Alice takes damage if left shift is pressed
            alice.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= bob.Damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //Player takes damage from alice if left alt is pressed
            playerHP -= alice.Damage;
            Debug.Log("Player HP: " + playerHP);
        }
        if (bob.Hitpoints < 1)
            //if bob's hp is under 1, he dies
            bob.Die();
        if (alice.Hitpoints < 1)
            //if alice's hp is under 1, she dies
            alice.Die();
        if (playerHP < 1)
            //if our hp is under 1, we die
            Debug.Log("You Died!");
    }
}
