using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public static AudioClip colorPress, back, sticker, bomb, trash, slider, tab, drawing;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        colorPress = Resources.Load<AudioClip>("Color");
        back = Resources.Load<AudioClip>("Back");
        sticker = Resources.Load<AudioClip>("Sticker");
        bomb = Resources.Load<AudioClip>("Bomb");
        trash = Resources.Load<AudioClip>("Trash");
        slider = Resources.Load<AudioClip>("Slider");
        tab = Resources.Load<AudioClip>("Tab");
        drawing = Resources.Load<AudioClip>("Drawing");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void Playsound(string clip)
    {
        switch (clip)
        {
            case "colorPress":
                audioSrc.PlayOneShot(colorPress);
                break;
            case "back":
                audioSrc.PlayOneShot(back);
                break;
            case "sticker":
                audioSrc.PlayOneShot(sticker);
                break;
            case "bomb":
                audioSrc.PlayOneShot(bomb);
                break;
            case "trash":
                audioSrc.PlayOneShot(trash);
                break;
            case "slider":
                audioSrc.PlayOneShot(slider);
                break;
            case "tab":
                audioSrc.PlayOneShot(tab);
                break;
            case "drawing":
                audioSrc.PlayOneShot(drawing);
                break;




        }
    }

    internal static void PlaySound(string v)
    {
        throw new NotImplementedException();
    }
}
