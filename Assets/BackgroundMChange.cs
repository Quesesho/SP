using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMChange : MonoBehaviour
{
    public AudioClip audio1;
    public AudioClip otherClip;
    public bool peligro = false;
    
    void Start(){
       //AudioSource audio = GetComponent<AudioSource>();
    }

    void Update(){
        if(peligro && GetComponent<AudioSource>().clip != otherClip) {
            GetComponent<AudioSource>().clip = otherClip;
            GetComponent<AudioSource>().Play();
        } else if(!peligro && GetComponent<AudioSource>().clip == otherClip){
            GetComponent<AudioSource>().clip = audio1;
            GetComponent<AudioSource>().Play();
        }


    }
}
