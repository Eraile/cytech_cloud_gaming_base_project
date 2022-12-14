using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerHorizontalAnimator : MonoBehaviour
{
    public Animator animator = null;
    public Rigidbody2D rb2D = null;
    public SpriteRenderer spriteRenderer = null;

    // Update is called once per frame
    protected virtual void Update()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        if (horizontalMove != 0.0f)
        {
            this.spriteRenderer.flipX = !(horizontalMove > 0f);
        }

        // Horizontal
        this.animator.SetFloat("Horizontal", Mathf.Abs(horizontalMove));
    }
}
