using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    [SerializeField]
    private float MaxTimeForLevel = 60.0f;

    public static float RemainingTime;

    private float timer;

    public static bool TimeIsOver = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        RemainingTime = MaxTimeForLevel;
    }

    // Update is called once per frame
    void Update()
    {
        countdown();
    }

    private void countdown(){
        timer += Time.deltaTime;

        if (timer>=1.0f && RemainingTime>0){
            timer-=1.0f;
            RemainingTime-=1.0f;
        }
        if (RemainingTime==0){
            TimeIsOver = true;
        }
    }
}
