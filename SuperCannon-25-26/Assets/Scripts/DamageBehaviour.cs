using System.Collections;
using UnityEngine;
using static Enemy;

public class DamageBehaviour : MonoBehaviour, ITakeDamage
{
    Animator animator;
    Rigidbody2D rb;

    SpriteRenderer _renderer;

    Enemy _enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _enemy = GetComponent<Enemy>();
        animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void ApplyDamage(int hitpoints)
    {
        if (hitpoints > 0)
        {
            
            GameData.Score += hitpoints;
            Debug.Log("Score: " + GameData.Score.ToString());
        }
        StartCoroutine(ApplyDamageEffect());
        _enemy.health--;
        Debug.Log("Enemy health: " + _enemy.health.ToString());
        if (_enemy.health <= 0)
        {         
            Destroy(this.gameObject);
        }
    }

    IEnumerator ApplyDamageEffect()
    {

        animator.SetBool("spin_trigger", true);
        Color oldenemyColor = _renderer.color;
        _renderer.color = Color.red;
        float oldGravity = rb.gravityScale;
        rb.gravityScale = 0.1f;
        yield return new WaitForSeconds(0.6f);
        _renderer.color = oldenemyColor;
        rb.gravityScale = oldGravity;
        animator.SetBool("spin_trigger", false);
    }


}
