using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance =null;

    [SerializeField]
    private GameObject PlayerCharacter;

    [SerializeField]
    private GameObject LevelKey;

    private bool IsLevelWinnable=true;

    public bool Pause = false;



    void Awake(){
        if (instance==null){
            instance=this;
        }
        else {
            DestroyImmediate(this);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerGetsKey();
        GamePaused();
    }

    private void PlayerGetsKey(){
        if (LevelKey==null && IsLevelWinnable==true){
            IsLevelWinnable=false;
        }
    }

    private void GamePaused(){
        if (Input.GetKeyDown("p")){
            Pause = !Pause;

            Debug.Log(Pause);
        }
    }
}
