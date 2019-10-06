using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeInteractionInfo : MonoBehaviour
{

    public Camera camera;
    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt;
    private Vector3 dist;

    // Use this for initialization
    void Start()
    {
        dist =  camera.transform.position- transform.position;
    }



    // Update is called once per frame
    void Update()
    {

        transform.position = camera.transform.position - dist;

        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                // execute pointerdown handler
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }

    }

    public void PointerEnterText()
    {
        gazedAt = true;
        Debug.Log("PointerEnter");

    }

    public void PointerExitText()
    {
        gazedAt = false;
        Debug.Log("PointerExit");
    }

    public void PointerDown()
    {
        Debug.Log("PointerDown");
    }
}