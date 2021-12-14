using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 1;

    public int Health = 40;

    public GameObject deadEnemy;

    public Animator enemyAnimation;

    public void TakeDamage (int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        enemyAnimation.GetFloat("Death");
        //enemyAnimation.SetBool("Death", true);
        ScoreManager.score++;
        Instantiate(deadEnemy, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ThePlayer"))
        {
            collision.GetComponent<CharacterControl2D>().health -= damage;
            ScoreManager.score++;
            Destroy(gameObject);
        }
    }
}
