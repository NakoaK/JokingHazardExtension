using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FreeDraw;

public class paintable : MonoBehaviour
{

    public GameObject brush;
    public float brushSize = 0.1f;
    public bool canPaint;


    public GameObject paintIcon;
    public GameObject stickerIcon;
    public Sprite paintIconON;
    public Sprite paintIconOFF;
    public Sprite stickerIconON;
    public Sprite stickerIconOFF;

    private float brushSizeSliderValue;

    public Drawable onPaint; //= new Drawable();
    public MoveSticker movement;
    public MoveText text;


    // Start is called before the first frame update
    void Start()
    {
        canPaint = false;
        movement.NoFuck();
        text.disableText();
        onPaint.NoDraw();

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void started()
    {
        paintMode();
    }

    public void stickerMode()
    {
        canPaint = false;

        onPaint.NoDraw();
        movement.YesFuck();
        text.disableText();
        SFX.Playsound("tab");

    }

    public void paintMode()
    {
        canPaint = true;

        if (canPaint)
        {
            onPaint.YesDraw();
            movement.NoFuck();
            text.disableText();
            SFX.Playsound("tab");
        }
        
    }

    public void TextMode()
    {
        canPaint = false;
        movement.NoFuck();
        text.enableText();
        SFX.Playsound("tab");


        onPaint.NoDraw();
    }

    public void stop()
    {
        canPaint = false;
        movement.NoFuck();
        text.disableText();
        onPaint.NoDraw();
        SFX.Playsound("tab");


    }

    public void updatebrushSize()
    {
        SFX.Playsound("slider");
        DrawingSettings updateSize = new DrawingSettings();
        updateSize.UpdateBrushSize();
    }
}
