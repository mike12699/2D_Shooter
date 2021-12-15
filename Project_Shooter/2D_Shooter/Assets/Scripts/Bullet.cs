using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles the bullet prefab
/// When fired it will have a speed of 20 and deal 20 damage to the enemies
/// </summary>
public class Bullet : MonoBehaviour
{
    public float Speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * Speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
