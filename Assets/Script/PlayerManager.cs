using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instantiate;
    public int MaxVida = 10;
    public bool isDead = false;
    public int vida=3;
    public int zone=0;
    public bool cambiando = false;
    // Start is called before the first frame update
    private void Awake() {
        instantiate=this;
    }
    private void Start()
    {
        vida = MaxVida;
    }
    // Update is called once per frame
    void Update()
    {
        IsDead();       
    }
    public void IsDead()
    {
        if (vida == 0)
        {
            isDead = true;
        }
    }
}
