using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSong : MonoBehaviour
{
    public AudioSource BG;
    public AudioClip theme;
    public AudioClip lab;
    // Start is called before the first frame update
    void Start()
    {
        int song = Random.Range(0, 4);
        if(song == 0 || song == 1 || song == 2)
        {
            this.GetComponent<AudioSource>().clip = theme;
        }
        else
        {
            this.GetComponent<AudioSource>().clip = lab;

        }

        //BG.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
