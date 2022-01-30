using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorPlayer_Move : MonoBehaviour
{
    [SerializeField]
    private GameObject XPosSetter;
    public float runSpeed = 2;

    public float jumpSpeed = 3;

    Rigidbody2D rb2D;

    public bool betterJump = false;

    public float fallMultiplier = 0.5f;

    public float lowJumpMultiplier = 1f;

    public SpriteRenderer spriteRenderer;

    public Animator animator;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(X_pos_setter.XChange, 0.0f, 0.0f);
        
        if (Input.GetKey("space") && CheckGrounds.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }

        if (CheckGrounds.isGrounded==false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (CheckGrounds.isGrounded==true)
        {
            animator.SetBool("Jump", false);
        }

        // if (betterJump)
        // {
        //     if (rb2D.velocity.y<0)
        //     {
        //         rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
        //     }
        //     if (rb2D.velocity.y>0 && !Input.GetKey("space"))
        //     {
        //         rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
        //     }

        // }
    }
}
