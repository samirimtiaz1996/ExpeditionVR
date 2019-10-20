using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceAssistant : MonoBehaviour
{
    public AudioClip rockCollision;    // Add your Audi Clip Here;
    public bool status=false;
    public int x1=273,x2=354,z1=170,z2=243;
    private void Awake()
    {
        GetComponent<AudioSource>().playOnAwake = false;
    }
    void Start()
    {
      //  GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = rockCollision;
        

    }

    void Update() 
    {
     //   Debug.Log("Checking"+transform.parent.localPosition.x);
        if ((transform.parent.localPosition.x > x1 && transform.parent.localPosition.x < x2) && (transform.parent.localPosition.z > z1 && transform.parent.localPosition.z < z2)  )
        {
            if( status == false) {
                GetComponent<AudioSource>().Play();
                Debug.Log("DONE DONE DONE DONE");
                status = true;
            }
            

        }
        else
        {
            status = false;
            //   GetComponent<AudioSource>().Stop();
        }

    }
}
