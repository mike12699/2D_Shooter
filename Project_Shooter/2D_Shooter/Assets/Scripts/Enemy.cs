using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 40;

    public GameObject deadEnemy;

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
        Instantiate(deadEnemy, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
