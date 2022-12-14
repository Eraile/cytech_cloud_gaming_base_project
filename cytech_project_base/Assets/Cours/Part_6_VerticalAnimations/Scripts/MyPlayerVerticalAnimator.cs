using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerVerticalAnimator : MyPlayerHorizontalAnimator
{
    protected override void Update()
    {
        base.Update();
        //// This code is executed by the "base.Update()" call
        //float horizontalMove = Input.GetAxisRaw("Horizontal");
        //if (horizontalMove != 0.0f)
        //{
        //    this.spriteRenderer.flipX = !(horizontalMove > 0f);
        //}

        //// Horizontal
        //this.animator.SetFloat("Horizontal", Mathf.Abs(horizontalMove));

        // Jump / Fall
        this.animator.SetFloat("Vertical", this.rb2D.velocity.y);
    }
}
