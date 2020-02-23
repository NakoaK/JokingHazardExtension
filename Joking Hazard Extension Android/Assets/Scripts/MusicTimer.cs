using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicTimer : MonoBehaviour
{
    public AudioSource musicSource;
    public float timerCount;
    public float timeLeft;
    public bool timerOn;
    public bool pauseOn;
    public bool started;

    public Sprite startOFF;
    public Sprite startON;
    public Sprite pauseOFF;
    public Sprite pauseON;

    public GameObject startButton;
    public GameObject pauseButton;

    public AudioSource BG;
    public AudioClip theme;
    public AudioClip lab;


    // Start is called before the first frame update
    void Start()
    {

        timerCount = 60f;
        started = false;
        timerOn = false;
        pauseOn = false;
        timeLeft = timerCount;

        startButton.GetComponent<Image>().sprite = startON;
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
            int song = Random.Range(0, 4);
            if (song == 0 || song == 1 || song == 2)
            {
                this.GetComponent<AudioSource>().clip = theme;
            }
            else
            {
                this.GetComponent<AudioSource>().clip = lab;

            }

            timeLeft = timerCount;
            timerOn = true;
            musicSource.Play();
            started = true;

            startButton.GetComponent<Image>().sprite = startOFF;

        }
    }

    public void pausePressed()
    {
        if(started)
        {
            if (!pauseOn)
            {
                pauseOn = true;
                Time.timeScale = 0;
                musicSource.Pause();
                pauseButton.GetComponent<Image>().sprite = pauseON;

                print("pressed pause");
            }
            else if (pauseOn)
            {
                pauseOn = false;
                Time.timeScale = 1;
                musicSource.UnPause();
                pauseButton.GetComponent<Image>().sprite = pauseOFF;

                print("Unpaused");

            }
        }
        

    }

    public void stopPressed()
    {
        musicSource.Stop();
        started = false;
        timerOn = false;
        pauseOn = false;
        Time.timeScale = 1;
        startButton.GetComponent<Image>().sprite = startON;
        pauseButton.GetComponent<Image>().sprite = pauseOFF;

    }
}
