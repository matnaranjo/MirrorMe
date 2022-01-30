using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static bool PlayerCol = false;
    private float NoPushCollisionX = 0.0f;
    private float NoPushCollisionY = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        NoPushCollisionX = collision.GetContact(0).normal.x;
        NoPushCollisionY = collision.GetContact(0).normal.y;

        if (collision.gameObject.CompareTag("NoPush")){
            PlayerCol = true;
            Debug.Log("aca");
        }
    }

    private void PlayerCollisionHandler(){
        if ((NoPushCollisionX>0.9f && X_pos_setter.XInput<0)||(NoPushCollisionX<-0.9f && X_pos_setter.XInput>0)){
            PlayerCol=false;
        }
    }
}
