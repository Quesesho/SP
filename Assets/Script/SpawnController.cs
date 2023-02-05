using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject spawns;
    public GameObject termita;
    public GameObject escarabajo;
    public GameObject spawnCollection;
    public float offSetStart=0;
    public float timeSpawn = 1;
    void Start()
    {
        InvokeRepeating("SpawnEnemys", offSetStart, timeSpawn);
    }
    void Update()
    {
        
    }
    private void SpawnEnemys()
    {
        int selecEnemy = Random.Range(0, 2);
        int lenSpawn= spawns.transform.GetChild(selecEnemy).childCount;
        int selecSpawn = Random.Range(0, lenSpawn);
        if (selecEnemy == 0)
        {
            Instantiate(escarabajo, 
                        spawns.transform.GetChild(selecEnemy).GetChild(selecSpawn)).transform.SetParent(spawnCollection.transform);
        }
        else
        {
            Instantiate(termita,
                        spawns.transform.GetChild(selecEnemy).GetChild(selecSpawn)).transform.SetParent(spawnCollection.transform);
        }
    }
}
