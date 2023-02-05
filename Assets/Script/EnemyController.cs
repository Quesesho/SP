using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int vidas=3;
    public float speed;
    public float speedDamage=.3f;
    public GameObject targets;
    public int damageReceived = 1;
    
    Vector2 direction;
    float distance;
    GameObject destination;
    bool isAttack = false;

    private void Start()
    {
        GetDestination();
    }
    void Update()
    {
        
        if(GetDistance()>1)
            MoveEnemy();
        if (GetDistance() > 1.2)
            isAttack = true;
        else isAttack = false;
        Attack();

        if (Input.GetKeyDown(KeyCode.Space))
            GetDestination();
        Dead();
    }
    private float GetDistance()
    {
        distance = Vector2.Distance(destination.transform.position, transform.position);
        return distance;
    }
    void MoveEnemy()
    {
        direction = destination.transform.position - transform.position;
        transform.Translate(direction * Time.deltaTime*speed);
    }
    private void GetDestination()
    {
        int lentarg = targets.transform.childCount;
        destination = targets.transform.GetChild(Random.Range(0, lentarg)).gameObject;
        Debug.Log(destination.tag);
        
    }
    public void GetDestination(GameObject newDestination)
    {
        destination = newDestination;
        Debug.Log(destination.gameObject.tag);
    }
    private void Attack()
    {
        if (isAttack)
        {
            if (destination.CompareTag("Player"))
            {
                InvokeRepeating("HitPlayer",0f,.3f);
            }
            if (destination.CompareTag("Arbol"))
            {
                InvokeRepeating("HitTree", 0f, .3f);
            }
        }
        else
        {
            CancelInvoke("HitPlayer");
        }
        
    }
    public void ReceiveDamage()
    {
        vidas-=damageReceived;
    }
    public void HitPlayer()
    {
        PlayerManager.instantiate.vida--;
        Debug.Log("Vidas jugador: " + PlayerManager.instantiate.vida);
    }
    public void HitTree()
    {

    }
    private void Dead()
    {
        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
    }
}
