using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    [SerializeField]
    private float MaxTimeForLevel = 60.0f;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countdown();
    }

    private void countdown(){
        timer += Time.deltaTime;

        if (timer>=0.1f){
            timer-=0.1f;
            MaxTimeForLevel-=0.1f;
        }
        Debug.Log(MaxTimeForLevel.ToString("#.#"));
    }
}
