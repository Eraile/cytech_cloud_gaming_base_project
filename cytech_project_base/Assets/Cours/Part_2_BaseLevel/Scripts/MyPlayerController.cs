using System.Collections;
using System.Collections.Generic;
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
}
