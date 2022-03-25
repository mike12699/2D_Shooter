using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilFaceController : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("ThePlayer").GetComponent<Transform>();
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
