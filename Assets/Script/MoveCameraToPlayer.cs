using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraToPlayer : MonoBehaviour
{
    Camera cam;
    float tmpx, tmpy, tmpz;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

         tmpx = PlayerManager.instantiate.transform.position.x;
        tmpy = PlayerManager.instantiate.transform.position.y;
        tmpz = cam.transform.position.z;
        //if (tmpx > -1.2 && tmpx < 1.2)
        //{
                cam.transform.position = new Vector3(tmpx,tmpy,tmpz);
        //}
            
        

    }
}
