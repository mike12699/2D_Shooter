using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce;
    private float moveInput;
    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;

    private bool grounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        else if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (grounded == true && Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.W) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }

            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            isJumping = false;
        }
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y);
    }
}