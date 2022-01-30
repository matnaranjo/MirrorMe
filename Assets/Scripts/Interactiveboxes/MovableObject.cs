using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    [SerializeField]
    private GameObject Box;

    private bool Grabbed= false;

    private float xcollision=0.0f;
    private float ycollision=0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CollisionHandler();
        BoxMovement();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        ycollision = collision.GetContact(0).normal.y;
        xcollision = collision.GetContact(0).normal.x;
        Debug.Log("gato");

        if (collision.gameObject.CompareTag("PlayerCharacter")){
            if (((xcollision>0.9f || xcollision<-0.9f) && ycollision == 0.0f)){Grabbed = true;}
        }  

        else if (collision.gameObject.CompareTag("NoPush")){
            PlayerCollision.PlayerCol= true;
            MirrorPlayerCollision.MirrorPlayerCol = true;
        }     

        
        
    }

    private void OnCollisionExit2D(){
        Grabbed=false;
    }

    private void BoxMovement(){
        
        if (Grabbed==true){
            Box.transform.position += new Vector3(X_pos_setter.XChange, 0.0f, 0.0f);
        }
    }

    private void CollisionHandler(){
        if ((xcollision>0.9f && X_pos_setter.XInput<0)||(xcollision<-0.9f && X_pos_setter.XInput>0)){
            Grabbed = false;
        }
    }
}
