using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingTimeDisplay : MonoBehaviour
{

    [SerializeField]
    private Text Counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Counter.text = "Remaining Time: "+ TimeManager.RemainingTime.ToString();
        Debug.Log(TimeManager.RemainingTime);
        
    }
}
