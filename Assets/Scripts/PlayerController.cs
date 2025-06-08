using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 7;
    public float jumpForce = 300;
    public Rigidbody2D rb;

    public GroundChecker groundChecker;
    public PlayerHealth health;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (health.isDead) return;

        float moveInput = Input.GetAxis("Horizontal");
        //Debug.Log($"Input value: {moveInput}");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && groundChecker.isGrounded)
        {
            //rb.AddForce(new Vector2(0,jumpForce));
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

}
