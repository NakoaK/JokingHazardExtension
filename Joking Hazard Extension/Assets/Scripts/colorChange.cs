using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using FreeDraw;

public class colorChange : MonoBehaviour
{
    public GameObject Brush;
    public Material PaintCanvasMat;

    public Sprite blackON;
    public Sprite blackOFF;
    public Material black;
    public GameObject blackButton;

    public Sprite purpleON;
    public Sprite purpleOFF;
    public Material purple;
    public GameObject purpleButton;

    public Sprite redON;
    public Sprite redOFF;
    public Material red;
    public GameObject redButton;

    public Sprite blueON;
    public Sprite blueOFF;
    public Material blue;
    public GameObject blueButton;

    public Sprite yellowON;
    public Sprite yellowOFF;
    public Material yellow;
    public GameObject yellowButton;

    public Sprite greenON;
    public Sprite greenOFF;
    public Material green;
    public GameObject greenButton;

    public Sprite eraserON;
    public Sprite eraserOFF; 
    public Material erase;
    public GameObject eraserButton;

    public bool eraseBool = false;

    public string Colour;


    // Start is called before the first frame update
    void Start()
    {
        blackButton.GetComponent<Image>().sprite = blackON;
        Brush.GetComponent<MeshRenderer>().material = black;

        DrawingSettings brushColor = new DrawingSettings();
        brushColor.SetMarkerBlack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void blackButtonPress()
    {
        Brush.GetComponent<MeshRenderer>().material = black;

        DrawingSettings brushColor = new DrawingSettings();
        brushColor.SetMarkerBlack();

        blackButton.GetComponent<Image>().sprite = blackON;
        redButton.GetComponent<Image>().sprite = redOFF;
        purpleButton.GetComponent<Image>().sprite = purpleOFF;
        greenButton.GetComponent<Image>().sprite = greenOFF;
        yellowButton.GetComponent<Image>().sprite = yellowOFF;
        blueButton.GetComponent<Image>().sprite = blueOFF;
        eraserButton.GetComponent<Image>().sprite = eraserOFF;

        eraseBool = false;

    }

    public void redButtonPress()
    {
        Brush.GetComponent<MeshRenderer>().material = red;

        DrawingSettings brushColor = new DrawingSettings();
        brushColor.SetMarkerRed();

        blackButton.GetComponent<Image>().sprite = blackOFF;
        redButton.GetComponent<Image>().sprite = redON;
        purpleButton.GetComponent<Image>().sprite = purpleOFF;
        greenButton.GetComponent<Image>().sprite = greenOFF;
        yellowButton.GetComponent<Image>().sprite = yellowOFF;
        blueButton.GetComponent<Image>().sprite = blueOFF;
        eraserButton.GetComponent<Image>().sprite = eraserOFF;

        eraseBool = false;

    }

    public void purpleButtonPress()
    {
        Brush.GetComponent<MeshRenderer>().material = purple;

        DrawingSettings brushColor = new DrawingSettings();
        brushColor.SetMarkerPurple();

        blackButton.GetComponent<Image>().sprite = blackOFF;
        redButton.GetComponent<Image>().sprite = redOFF;
        purpleButton.GetComponent<Image>().sprite = purpleON;
        greenButton.GetComponent<Image>().sprite = greenOFF;
        yellowButton.GetComponent<Image>().sprite = yellowOFF;
        blueButton.GetComponent<Image>().sprite = blueOFF;
        eraserButton.GetComponent<Image>().sprite = eraserOFF;

        eraseBool = false;

    }

    public void greenButtonPress()
    {
         Brush.GetComponent<MeshRenderer>().material = green;

        DrawingSettings brushColor = new DrawingSettings();
        brushColor.SetMarkerGreen();

        blackButton.GetComponent<Image>().sprite = blackOFF;
        redButton.GetComponent<Image>().sprite = redOFF;
        purpleButton.GetComponent<Image>().sprite = purpleOFF;
        greenButton.GetComponent<Image>().sprite = greenON;
        yellowButton.GetComponent<Image>().sprite = yellowOFF;
        blueButton.GetComponent<Image>().sprite = blueOFF;
        eraserButton.GetComponent<Image>().sprite = eraserOFF;

        eraseBool = false;

    }

    public void blueButtonPress()
    {
        Brush.GetComponent<MeshRenderer>().material = blue;

        DrawingSettings brushColor = new DrawingSettings();
        brushColor.SetMarkerBlue();

        blackButton.GetComponent<Image>().sprite = blackOFF;
        redButton.GetComponent<Image>().sprite = redOFF;
        purpleButton.GetComponent<Image>().sprite = purpleOFF;
        greenButton.GetComponent<Image>().sprite = greenOFF;
        yellowButton.GetComponent<Image>().sprite = yellowOFF;
        blueButton.GetComponent<Image>().sprite = blueON;
        eraserButton.GetComponent<Image>().sprite = eraserOFF;

        eraseBool = false;

    }

    public void yellowButtonPress()
    {
        Brush.GetComponent<MeshRenderer>().material = yellow;

        DrawingSettings brushColor = new DrawingSettings();
        brushColor.SetMarkerYellow();

        blackButton.GetComponent<Image>().sprite = blackOFF;
        redButton.GetComponent<Image>().sprite = redOFF;
        purpleButton.GetComponent<Image>().sprite = purpleOFF;
        greenButton.GetComponent<Image>().sprite = greenOFF;
        yellowButton.GetComponent<Image>().sprite = yellowON;
        blueButton.GetComponent<Image>().sprite = blueOFF;
        eraserButton.GetComponent<Image>().sprite = eraserOFF;

        eraseBool = false;


    }

    public void eraserButtonPress()
    {
        Brush.GetComponent<MeshRenderer>().material = erase;

        eraseBool = true;

        //Brush.GetComponent<MeshRenderer>().material = PaintCanvasMat;

        DrawingSettings brushColor = new DrawingSettings();
        brushColor.SetEraser();


        blackButton.GetComponent<Image>().sprite = blackOFF;
        redButton.GetComponent<Image>().sprite = redOFF;
        purpleButton.GetComponent<Image>().sprite = purpleOFF;
        greenButton.GetComponent<Image>().sprite = greenOFF;
        yellowButton.GetComponent<Image>().sprite = yellowOFF;
        blueButton.GetComponent<Image>().sprite = blueOFF;
        eraserButton.GetComponent<Image>().sprite = eraserON;

    }

    public void bombButtonPress()
    {
      SceneManager.LoadScene("EditorScene"); //restart
    }

    public void OnMouseDown()
    {
        if (eraseBool)
            Object.Destroy(Brush);
    }

}
