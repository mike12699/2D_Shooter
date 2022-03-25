using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienStatesController : MonoBehaviour
{
    public enum AlienStates { idle, walking };
    public float followDistance;
    public float ignoreDistance;
    public static float walkingSpeed = 0.1f;
    public AlienStates alienStates;
    [SerializeField] Transform _player;

    private void Awake()
    {
        Enemy.spriteRenderer = GetComponent<SpriteRenderer>();
        Enemy.enemyAnimation = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.position.x < transform.position.x)
        {
            Enemy.spriteRenderer.flipX = true;
        }
        else
        {
            Enemy.spriteRenderer.flipX = false;
        }

        if (Vector2.Distance(transform.position, _player.position) > followDistance && Vector2.Distance(transform.position, _player.position) < ignoreDistance)
        {
            alienStates = AlienStates.walking;
            Enemy.enemyAnimation.SetTrigger("walking");
        }
        else
        {
            alienStates = AlienStates.idle;
            Enemy.enemyAnimation.SetTrigger("idle");
        }
    }
}
