using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int vidas;
    public int speed;

    // Update is called once per frame
    void Update()
    {
        
    }
<<<<<<< Updated upstream
=======
    private void EdoAttack()
    {
        Transform pos = GetDestination();
        
        //xpos = Mathf.Clamp();
    }
    private Transform GetDestination()
    {
        int lentarg = targets.transform.childCount;
        return targets.transform.GetChild(Random.Range(0,lentarg));
    }
>>>>>>> Stashed changes
}
