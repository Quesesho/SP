using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instantiate; 
    public int vida=3;
    public bool isArriba=true;
    // Start is called before the first frame update
private void Awake() {
    instantiate=this;
}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}