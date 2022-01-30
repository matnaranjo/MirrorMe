using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject NegaVerison;
    public static bool PlayerCol = false;
    private float NoPushCollisionX = 0.0f;
    private float NoPushCollisionY = 0.0f;
    private Vector3 PosTemp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerCollisionHandler();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        NoPushCollisionX = collision.GetContact(0).normal.x;
        NoPushCollisionY = collision.GetContact(0).normal.y;

        PosTemp = transform.position;

        PosTemp.y = NegaVerison.transform.position.y;

        if (NoPushCollisionX!=0){
            NegaVerison.transform.position = PosTemp;
        }
        
        if (collision.gameObject.CompareTag("NoPush")){
            if (NoPushCollisionY==0){PlayerCol = true;}
        }
    }

    private void OnCollisionExit2D(){
        PlayerCol=false;
    }

    private void PlayerCollisionHandler(){


        if ((NoPushCollisionX>0.9f && X_pos_setter.XInput>0)||(NoPushCollisionX<-0.9f && X_pos_setter.XInput<0)){
            PlayerCol=false;
            
            
        }
    }
}
