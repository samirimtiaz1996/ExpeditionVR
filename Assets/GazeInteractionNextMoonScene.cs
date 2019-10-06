using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class GazeInteractionNextMoonScene : MonoBehaviour
{
  //  public GameObject lunarLander;
  //  public Text text;
    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt;
    public static int number=4;
    public int test;
    public Text text;

    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

        if (gazedAt)
        {
            test=number;
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                // execute pointerdown handler
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
                if (number== 4) { number = 13; text.text = "Done"; }
                else if (number == 13) {number=14; text.text = "Done"; }
                else if (number == 14) { number = 17; text.text = "Done"; }
                else if(number == 17) { number = 21; text.text = "Done"; }
                else if(number == 21) { number = 4; text.text = "Done"; }
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
        text.text = "look at moon from another angle";
        Debug.Log("PointerExit");
        
    }

    public void PointerDown()
    {
        Debug.Log("PointerDown");


    }
}
