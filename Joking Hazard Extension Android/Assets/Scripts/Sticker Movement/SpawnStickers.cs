using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStickers : MonoBehaviour
{
    public GameObject prefab;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = prefab.gameObject.GetComponent<SpriteRenderer>(); //get sprite renderer & store it
    }

    public void buttonPress()
    { 
        Instantiate(prefab, new Vector3(0,0, 95), Quaternion.identity);
        SFX.Playsound("sticker");

    }
    public void change(Sprite differentSprite)
    {
        spriteRenderer.sprite = differentSprite; //sets sprite renderers sprite
    }

}
