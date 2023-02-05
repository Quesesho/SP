using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerS : MonoBehaviour
{
    public float tRR;
    public float tRD;
    private float timeRemaining;
    private float timeRD;
    public bool esCero;
    // Start is called before the first frame update
    void Start()
    {
        esCero = false;
        timeRemaining = tRR;
        timeRD = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(timeRemaining);
        Debug.Log(timeRD);
        if(timeRemaining > 0 && timeRD <= 0){
            esCero = false;
            timeRemaining -= Time.deltaTime;
        }            
        else{
            if(timeRD <= 0){
                timeRD = tRD;
                timeRemaining = tRR;
            }                
            esCero = true;
            timeRD -= Time.deltaTime;
        }
    }
}
