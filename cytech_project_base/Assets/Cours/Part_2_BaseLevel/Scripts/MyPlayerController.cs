using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyPlayerController : MonoBehaviour
{
    public float horizontalInput = 0.0f;
    public Rigidbody2D rigidbody2D = null;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        this.horizontalInput = Input.GetAxisRaw("Horizontal");
        this.UpdateGroundedStatus();
        this.HandleJump();
    }

    void FixedUpdate()
    {
        this.HandleHorizontalMove();
    }

    public float speedFactor = 5.0f;
    void HandleHorizontalMove()
    {
        this.rigidbody2D.velocity = new Vector2(this.horizontalInput * this.speedFactor, this.rigidbody2D.velocity.y);
    }

    public float jumpForce = 300.0f;
    void HandleJump()
    {
        if (this.isGrounded == false)
            return;

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            this.rigidbody2D.AddForce(new Vector2(0f, this.jumpForce));
        }
    }

    public bool isGrounded = false;
    public Transform groundCheck = null;
    public float groundCheckRadius = 1.0f;
    void UpdateGroundedStatus()
    {
        // Reset flag
        this.isGrounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(this.groundCheck.position, this.groundCheckRadius);
        if (colliders != null)
        {
            for (int i=0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject != this.gameObject)
                    this.isGrounded = true;
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(this.groundCheck.position, this.groundCheckRadius);
    }
}
