using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRadius : MonoBehaviour
{
    EnemyController enemy;
    void Start()
    {
        enemy = GetComponentInParent<EnemyController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemy.GetDestination(collision.gameObject);
            
        }
    }
}
