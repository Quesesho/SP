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
    bool isPlayerDamage = false;
    bool isTreeDamage = false;
    public int zone=0;
    bool isTreeTarget = false;

    private void Start()
    {
        GetDestination();
    }
    void Update()
    {

        if (GetDistance() > 1)
        {
            if (!destination.active)
                GetDestination(PlayerManager.instantiate.gameObject);
            MoveEnemy();
            
        }
            
        if (GetDistance() > 1.2)
            isAttack = true;
        else isAttack = false;
        Attack();
        Dead();
        if (isTreeTarget == false)
        {
            if (zone != PlayerManager.instantiate.zone)
            {
                GetDestination();
                if (isPlayerDamage)
                {
                    CancelInvoke("HitPlayer");
                    isPlayerDamage = false;
                }
            }

        }
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
        isTreeTarget = true;
        int lentarg = targets.transform.childCount;
        destination = targets.transform.GetChild(Random.Range(0, lentarg)).gameObject;
        Debug.Log(destination.tag);
        
    }
    public void GetDestination(GameObject newDestination)
    {
        isTreeTarget = false;
        destination = newDestination;
        Debug.Log(destination.gameObject.tag);
    }
    private void Attack()
    {
        if (isAttack)
        {
            if (destination.CompareTag("Player"))
            {
                if (!isPlayerDamage)
                {
                   //Debug.Log("golpea");
                    if (isTreeDamage) CancelInvoke("HitTree");
                    InvokeRepeating("HitPlayer", 0f, speedDamage);
                    isPlayerDamage = true;
                }
                    

            }
            if (destination.CompareTag("Arbol"))
            {

                if (!isTreeDamage)
                {
                   if (isPlayerDamage) CancelInvoke("HitPlayer");
                    InvokeRepeating("HitTree", 0f, speedDamage);
                    isTreeDamage = true;
                }
                
            }
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
        ArbolManager.instantiate.SetDamage(destination.name);
    }
    private void Dead()
    {
        
        if (vidas <= 0)
        {
            if (isPlayerDamage) CancelInvoke("HitPlayer");
            if (isTreeDamage) CancelInvoke("HitTree");
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            ReceiveDamage();
        }
    }
}
