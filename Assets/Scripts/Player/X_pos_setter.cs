using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_pos_setter : MonoBehaviour
{

    public static float XInput = 0.0f;
    public float PlayerSpeed = 2;

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject MirrorPlayer;

    private Animator PlayerAnimator;
    private Animator MirrorPlayerAnimator;

    private SpriteRenderer PlayerSpriteRenderer;

    private SpriteRenderer MirrorPlayerSpriteRenderer;
    public static float XChange;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimator= Player.GetComponent<Animator>();
        MirrorPlayerAnimator = MirrorPlayer.GetComponent<Animator>();

        PlayerSpriteRenderer = Player.GetComponent<SpriteRenderer>();
        MirrorPlayerSpriteRenderer = MirrorPlayer.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        XMovement();
    }

    private void XMovement(){

        

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            XInput = Input.GetAxisRaw("Horizontal");
            XChange = XInput * Time.fixedDeltaTime * PlayerSpeed;

            PlayerAnimator.SetBool("Run", true);
            MirrorPlayerAnimator.SetBool("Run", true);

            PlayerSpriteRenderer.flipX = false;
            MirrorPlayerSpriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey("left")){
            XInput = Input.GetAxisRaw("Horizontal");
            XChange = XInput * Time.fixedDeltaTime * PlayerSpeed;

            PlayerAnimator.SetBool("Run", true);
            MirrorPlayerAnimator.SetBool("Run", true);

            PlayerSpriteRenderer.flipX = true;
            MirrorPlayerSpriteRenderer.flipX = true;
        }

        else
        {  
            XChange = 0.0f;
            PlayerAnimator.SetBool("Run", false);
            MirrorPlayerAnimator.SetBool("Run", false);
        }

        if (PlayerCollision.PlayerCol){XChange=0;}

        transform.position += new Vector3(XChange, 0.0f, 0.0f);
        

    }
}
