using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject spawns;
    public GameObject termita;
    public GameObject escarabajo;
    public GameObject spawnCollection;
    private GameObject term = termita;
    private GameObject escar = escarabajo;
    //public int tenem;
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
        Debug.Log("Genera Spawn");
        GameObject tmpGO;
        int selecEnemy = Random.Range(0, 2);
        int lenSpawn= spawns.transform.GetChild(selecEnemy).childCount;
        int selecSpawn = Random.Range(0, lenSpawn);
        if (selecEnemy == 0)
        {
            tmpGO = Instantiate(escarabajo,
                          spawns.transform.GetChild(selecEnemy).GetChild(selecSpawn));
            EnemyController enemytmp = tmpGO.GetComponent<EnemyController>();
            enemytmp.zone = selecEnemy;
           tmpGO.transform.SetParent(spawnCollection.transform);
            
        }
        else
        {
            tmpGO = Instantiate(termita,
                          spawns.transform.GetChild(selecEnemy).GetChild(selecSpawn));
            EnemyController enemytmp = tmpGO.GetComponent<EnemyController>();
            enemytmp.zone = selecEnemy;
            tmpGO.transform.SetParent(spawnCollection.transform);
            //Instantiate(termita,
            //            spawns.transform.GetChild(selecEnemy).GetChild(selecSpawn)).transform.SetParent(spawnCollection.transform);
        }
    }
}
