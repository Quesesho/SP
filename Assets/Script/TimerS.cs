using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerS : MonoBehaviour
{
    public float timeRemaining;
    public bool esCero;
    // Start is called before the first frame update
    void Start()
    {
        esCero = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(timeRemaining);
        if(timeRemaining > 0)
            timeRemaining -= Time.deltaTime;
        else
            esCero = true;
    }
}
