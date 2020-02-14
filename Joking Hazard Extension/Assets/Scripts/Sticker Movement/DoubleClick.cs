using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleClick : MonoBehaviour
{
    public float firstClickTime, timeBetweenClicks;
    private bool coroutineAllowed;
    private int clickCounter;
    private int flip = 180;
    public MoveSticker kill;

    void Start()
    {
        firstClickTime = 0f;
        timeBetweenClicks = 0.2f;
        clickCounter = 0;
        coroutineAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            clickCounter += 1;
        }

        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
    }

    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;
        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                Debug.Log("Double Click");
                kill.doubleClick = true;
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;

    }
}
