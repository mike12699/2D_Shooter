using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum AlienStates { idle, walking };

    [SerializeField] Transform _player;

    public int damage = 1;
    public int Health = 40;
    public float followDistance;
    public float ignoreDistance;
    public static float walkingSpeed = 0.1f;
    public AlienStates alienStates;
    public static SpriteRenderer spriteRenderer;
    public GameObject deadEnemy;
    public static Animator enemyAnimation;

    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemyAnimation = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_player.position.x < transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }

        if (Vector2.Distance(transform.position, _player.position) > followDistance && Vector2.Distance(transform.position, _player.position) < ignoreDistance)
        {
            alienStates = AlienStates.walking;
            enemyAnimation.SetTrigger("walking");
        }
        else
        {
            alienStates = AlienStates.idle;
            enemyAnimation.SetTrigger("idle");
        }
    }

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
