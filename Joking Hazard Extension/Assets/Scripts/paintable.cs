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

    Drawable onPaint = new Drawable();


    // Start is called before the first frame update
    void Start()
    {
        canPaint = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && canPaint)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit paint;
            if (Physics.Raycast(ray, out paint))
            {
                var go = Instantiate(brush, paint.point + Vector3.back * 0.1f, Quaternion.Euler(-90, 0, 0), transform);
                go.transform.localScale = Vector3.one * brushSize;
            }
        }

        updatebrushSize();
    }

    public void stickerMode()
    {
        canPaint = false;

        onPaint.noDraw();
        stickerIcon.GetComponent<Image>().sprite = stickerIconON;
        paintIcon.GetComponent<Image>().sprite = paintIconOFF;
    }

    public void paintMode()
    {
        canPaint = true;

        onPaint.yesDraw();
        paintIcon.GetComponent<Image>().sprite = paintIconON;
        stickerIcon.GetComponent<Image>().sprite = stickerIconOFF;
    }

    public void updatebrushSize()
    {
        DrawingSettings updateSize = new DrawingSettings();
        updateSize.UpdateBrushSize();

        brushSizeSliderValue = GameObject.Find("BrushSlider").GetComponent<Slider>().value;
        brushSizeSliderValue = brushSizeSliderValue / 20;
        brushSize = brushSizeSliderValue;

    }
}
