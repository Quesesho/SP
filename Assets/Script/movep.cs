using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class movep : MonoBehaviour
{
    public float speed;
    private PlayerA playerA;
    public Rigidbody2D rbody;
    private Vector2 moveI;
    private bool canChange= false;

    void Awake() 
    {
        playerA = new PlayerA();
    }

    private void OnEnable() 
    {
        playerA.PlayerM.Enable();
    }

    private void OnDisable() 
    {
        playerA.PlayerM.Disable();
    }

    private void Attack()
    {
        if(canChange)
            Debug.Log("Atacku the Otaku");
        else
            Debug.Log("Tiradle piedras al otaku");
    }

    // Update is called once per frame
    void Update()
    {
        moveI = playerA.PlayerM.Move.ReadValue<Vector2>();
        if(!canChange){
            moveI.y=0;
        }
        rbody.velocity = moveI * speed;
        if(playerA.PlayerM.Fire.triggered) Attack();
    }

    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("Tuneles")){
            canChange = true;
            Debug.Log("Adentro");
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Tuneles")){
            canChange = false;
        }
    }
}
