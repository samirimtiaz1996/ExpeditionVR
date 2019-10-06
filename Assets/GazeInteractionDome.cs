using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GazeInteractionDome : MonoBehaviour
{

    public Text text;
    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt;

    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

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

    public void PointerEnter()
    {
        gazedAt = true;
        Debug.Log("PointerEnter");
        text.text = "Future of moon,BioDomes planted on moon surface.Nasa is planning to return on moon";

    }

    public void PointerExit()
    {
        gazedAt = false;
        Debug.Log("PointerExit");
        text.text = " ";
    }

    public void PointerDown()
    {
        Debug.Log("PointerDown");
    }
}