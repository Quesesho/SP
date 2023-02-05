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
    void Update()
    {
        moveI = playerA.PlayerM.Move.ReadValue<Vector2>();
        if(PlayerManager.instantiate.zone==0){
            moveI.y=0;
        }
        rbody.velocity = moveI * speed;
        if(playerA.PlayerM.Fire.triggered) Attack();

        if (canChange)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (PlayerManager.instantiate.cambiando == false)
                {
                    if (PlayerManager.instantiate.zone == 0)
                    {
                        PlayerManager.instantiate.zone = 1;
                        transform.Translate(Vector2.up*-3.0f);
                    }
                    else
                    {
                        PlayerManager.instantiate.zone = 0;
                        transform.Translate(Vector2.up * 3.0f);
                    }
                    PlayerManager.instantiate.cambiando = true;
                    Invoke("cambiandoTime", .5f);
                }
                
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("Tuneles")){
            canChange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Tuneles")){
            canChange = false;
        }
    }
    private void cambiandoTime()
    {
        PlayerManager.instantiate.cambiando = false;
    } 
}
