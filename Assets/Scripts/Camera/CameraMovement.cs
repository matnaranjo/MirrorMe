using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField]
    private GameObject ObjectToFollow;

    private Transform ObjectToFollowTransform;

    private Vector3 CameraPos;
    // Start is called before the first frame update
    void Start()
    {
        ObjectToFollowTransform = ObjectToFollow.GetComponent<Transform>();
        CameraPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer(){
        if (ObjectToFollowTransform.position.x>-15 && ObjectToFollowTransform.position.x<15){
            CameraPos.x = ObjectToFollowTransform.position.x;
            transform.position = CameraPos;
        }
            
    }
}
