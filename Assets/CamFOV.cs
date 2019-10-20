using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFOV : MonoBehaviour
{
    //This is the field of view that the Camera has
    float m_FieldOfView;
    public Camera cam;
    void Start()
    {
        //Start the Camera field of view at 60
        m_FieldOfView = 65.0f;
    }

    void Update()
    {
        //Update the camera's field of view to be the variable returning from the Slider
        cam.fieldOfView = m_FieldOfView;
    }

}
