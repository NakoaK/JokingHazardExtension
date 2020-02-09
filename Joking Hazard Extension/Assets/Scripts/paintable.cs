using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            if(Physics.Raycast(ray, out paint))
            {
                var go = Instantiate(brush, paint.point + Vector3.back * 0.1f, Quaternion.Euler(-90,0,0), transform);
                go.transform.localScale = Vector3.one * brushSize;
            }
        }

        updatebrushSize();
    }

    public void stickerMode()
    {
        canPaint = false;
        stickerIcon.GetComponent<Image>().sprite = stickerIconON;
        paintIcon.GetComponent<Image>().sprite = paintIconOFF;
    }

    public void paintMode()
    {
        canPaint = true;
        paintIcon.GetComponent<Image>().sprite = paintIconON;
        stickerIcon.GetComponent<Image>().sprite = stickerIconOFF;
    }

    public void updatebrushSize()
    {
        brushSizeSliderValue = GameObject.Find("BrushSlider").GetComponent<Slider>().value;
        brushSizeSliderValue = (brushSizeSliderValue / 10) + .05f;
        brushSize = brushSizeSliderValue;
    }
}
