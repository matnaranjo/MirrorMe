using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorPlayerCollision : MonoBehaviour
{

    [SerializeField]
    private GameObject NegaVerison;

    public static bool MirrorPlayerCol = false;
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
        MirrorPlayerCollisionHandler();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        NoPushCollisionX = collision.GetContact(0).normal.x;
        NoPushCollisionY = collision.GetContact(0).normal.y;

        PosTemp = transform.position;

        PosTemp.y = NegaVerison.transform.position.y;

        NegaVerison.transform.position = PosTemp;

        if (collision.gameObject.CompareTag("NoPush")){
            MirrorPlayerCol = true;
        }
    }

    private void OnCollisionExit2D(){
        MirrorPlayerCol=false;
    }

    private void MirrorPlayerCollisionHandler(){


        if ((NoPushCollisionX>0.9f && X_pos_setter.XInput>0)||(NoPushCollisionX<-0.9f && X_pos_setter.XInput<0)){
            MirrorPlayerCol=false;
        }
    }
}
