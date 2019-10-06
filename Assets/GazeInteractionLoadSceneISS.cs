using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GazeInteractionLoadSceneISS : MonoBehaviour
{
    //  public GameObject lunarLander;
    //  public Text text;
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
                SceneManager.LoadScene(2);
                timer = 0f;
               
            }
        }

    }

    public void PointerEnter()
    {
        gazedAt = true;
        Debug.Log("PointerEnter");


    }

    public void PointerExit()
    {
        gazedAt = false;
        Debug.Log("PointerExit");

    }

    public void PointerDown()
    {
        Debug.Log("PointerDown");


    }
}
