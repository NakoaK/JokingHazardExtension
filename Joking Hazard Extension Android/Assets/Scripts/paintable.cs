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
        canPaint = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0) && canPaint)
        //{
        //    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit paint;
        //    if (Physics.Raycast(ray, out paint))
        //    {
        //        var go = Instantiate(brush, paint.point + Vector3.back * 0.1f, Quaternion.Euler(-90, 0, 0), transform);
        //        go.transform.localScale = Vector3.one * brushSize;
        //    }
        //}

        //updatebrushSize();
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

        onPaint.YesDraw();
        movement.NoFuck();
        text.disableText();
        SFX.Playsound("tab");


        
    }

    public void TextMode()
    {
        canPaint = false;
        movement.NoFuck();
        text.enableText();
        SFX.Playsound("tab");


        onPaint.NoDraw();
    }

    public void updatebrushSize()
    {
        SFX.Playsound("slider");
        DrawingSettings updateSize = new DrawingSettings();
        updateSize.UpdateBrushSize();
    }
}
