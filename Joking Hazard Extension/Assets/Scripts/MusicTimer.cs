using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTimer : MonoBehaviour
{
    public AudioSource musicSource;
    public float timerCount;
    public float timeLeft;
    public bool timerOn;
    public bool pauseOn;
    public bool started;

    // Start is called before the first frame update
    void Start()
    {
        timerCount = 5f;
        started = false;
        timerOn = false;
        pauseOn = false;
        timeLeft = timerCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn)
        {
            timeLeft -= Time.deltaTime;
            if(timeLeft < 0)
            {
                timerOn = false;
                musicSource.Stop();
            }
        }
    }

    public void startPressed()
    {
        if(!started)
        {
            timeLeft = timerCount;
            timerOn = true;
            musicSource.Play();
            started = true;
        }
    }

    public void pausePressed()
    {
        if(!pauseOn)
        {
            pauseOn = true;
            Time.timeScale = 0;
            musicSource.Pause();
            print("pressed pause");
        }
        else if(pauseOn)
        {
            pauseOn = false;
            Time.timeScale = 1;
            musicSource.UnPause();
            print("Unpaused");
            
        }

    }

    public void stopPressed()
    {
        musicSource.Stop();
        started = false;
        timerOn = false;
        pauseOn = false;
        Time.timeScale = 1;
    }
}
