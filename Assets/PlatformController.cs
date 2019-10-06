using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformController : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngel = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    private CharacterController cc;
    /** //movement target
     public Transform target;

     //speed
     public float speed = 1;

     //flaf whethetr we are moving or not

     bool isMoving = false;

     // Start is called before the first frame update
     void Start()
     {
         
     }

     // Update is called once per frame
     void Update()
     {
         //check for input
         HandleInput();


         //move out platform
         HandleMovement();
     }

     private void HandleInput()
     {
         //check for fire1 axis
         if (Input.GetButtonDown("Fire1"))
         {
             //negate is moving
             isMoving = !isMoving;
         }
     }

     //take care of movement

     void HandleMovement()
     {
         //if we are not moving exit
         if (!isMoving) return;
         //calculate distance from target
         //float distance = Vector3.Distance(transform.position, target.position);
         //have we arrived
         if (distance > 0)
         {
             //calculate how much we need to move (steps) d = v * t
             float step = transform.position.y;
             // move by the step
             += 20 * Time.deltaTime;

         }
     }**/
    private void Start()
    {
        cc = GetComponent<CharacterController>();

    }

    private void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngel && vrCamera.eulerAngles.x < 90)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
    }
}
