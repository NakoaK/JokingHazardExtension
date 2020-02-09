using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    public bool muted;
    public AudioSource soundDevice;
    public Sprite normal;
    public Sprite mutedSprite;
    public GameObject muteButton;

    public void Start()
    {
        muted = false;
    }

    public void muteUnMute()
    {
        if(muted == false)
        {
            muted = true;
            soundDevice.Pause();
            muteButton.GetComponent<Image>().sprite = mutedSprite;
        }

        else if (muted == true)
        {
            muted = false;
            soundDevice.UnPause();
            muteButton.GetComponent<Image>().sprite = normal;

        }
    }
}
