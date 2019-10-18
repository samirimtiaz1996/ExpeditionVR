using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetectedBoulder : MonoBehaviour
{
    public AudioClip BoulderCollision;    // Add your Audi Clip Here;
                                          // This Will Configure the  AudioSource Component; 
                                          // MAke Sure You added AudioSouce to death Zone;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = BoulderCollision;
    }

    void OnCollisionEnter()  //Plays Sound Whenever collision detected
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("Collision boulder");

    }
}