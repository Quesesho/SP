using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulpomateB : MonoBehaviour
{
    public float speed;
    public float cura;
    public Vector2 objetivo;
    private Vector2 posicion;
    public TimerS timer;

    // Start is called before the first frame update
    void Start()
    {
        posicion = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.esCero)
            OnRoundEnd();
    }

    public void OnRoundEnd()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, objetivo, step);
    }

    public void OnRoundStart()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, posicion, step);
    }
}
