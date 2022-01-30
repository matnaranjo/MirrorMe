using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{

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

        if (((xcollision>0.9f || xcollision<-0.9f) && ycollision == 0.0f)){Grabbed = true;}
        
    }
    private void BoxMovement(){
        if (Grabbed==true){
            transform.position += new Vector3(X_pos_setter.XInput, 0.0f, 0.0f);
        }
    }

    private void CollisionHandler(){
        if ((xcollision>0.9f && X_pos_setter.XInput<0)||(xcollision<-0.9f && X_pos_setter.XInput>0)){
            Grabbed = false;
        }
    }
}
