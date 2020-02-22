using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string tempTime;
    [SerializeField] private float mainTimer;

    private float timer;
    private bool doOnce = false;
    private bool startedCount = false;
    private bool paused = false;
    public TextMeshProUGUI showTime;

    private void Start()
    {
        timer = mainTimer;
    }

    private void Update()
    {
        if (timer >= 0f && startedCount)
        {
            timer -= Time.deltaTime;
            tempTime = timer.ToString("F");
            showTime.text = tempTime;
        }
        else if (timer <= 0f && !doOnce)
        {
            doOnce = true;
            startedCount = false;
            showTime.text = "0.00";
            timer = 0.0f;
        }
    }

    public void resetTimer()
    {
        timer = mainTimer;
        startedCount = true;
        doOnce = false;
    }

    public void StartCount()
    {
        if(!startedCount)
        {
            startedCount = true;
            timer = mainTimer;
            Time.timeScale = 1;
        }
       
    }

    public void stopCount()
    {
        startedCount = false;
        showTime.text = "60";
        paused = false;

        doOnce = false;
    }

    public void pauseCount()
    {
        if(startedCount)
        {
            if (!paused)
        {
            Time.timeScale = 0;
            paused = true;
        }
        else if (paused)
        {
            Time.timeScale = 1;
            paused = false;
        }
        }
        
    }
}
