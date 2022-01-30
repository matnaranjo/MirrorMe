using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelKeyFunctions : MonoBehaviour
{
    [SerializeField]
    private float Angle= 0f;

    [SerializeField]
    private Transform KeyHolder;
    
    private string PlayerTag = "PlayerCharacter";
    // Start is called before the first frame update
    void Start()
    {
        Angle*= Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        LevelKeyMovement();
    }

    private void OnCollisionEnter2D(Collision2D col){

        if (col.gameObject.CompareTag(PlayerTag)){
            Destroy(this.gameObject);
        }

    }

    private void LevelKeyMovement(){
        transform.RotateAround(KeyHolder.gameObject.transform.position, KeyHolder.gameObject.transform.forward, -Angle);
    }
}
