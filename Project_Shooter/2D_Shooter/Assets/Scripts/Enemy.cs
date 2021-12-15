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

    /// <summary>
    /// This was supposed to trigger a death animation
    /// Only destroys the game object when health is at 0
    /// </summary>
    void Die()
    {
        enemyAnimation.GetFloat("Death");
        //enemyAnimation.SetBool("Death", true);
        ScoreManager.score++;
        Instantiate(deadEnemy, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    /// <summary>
    /// When enemy dies add one to the score board
    /// </summary>
    /// <param name="collision"></param>
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
