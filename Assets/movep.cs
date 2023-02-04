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
        Debug.Log("Atacku the Otaku");
    }

    // Update is called once per frame
    void Update()
    {
        moveI = playerA.PlayerM.Move.ReadValue<Vector2>();
        rbody.velocity = moveI * speed;
        if(playerA.PlayerM.Fire.triggered) Attack();
    }
}
