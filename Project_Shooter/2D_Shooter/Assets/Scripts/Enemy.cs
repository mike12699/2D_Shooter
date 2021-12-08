using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
        //enemyAnimation.GetFloat("Death");
        enemyAnimation.SetBool("Death", true);
        Instantiate(deadEnemy, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
