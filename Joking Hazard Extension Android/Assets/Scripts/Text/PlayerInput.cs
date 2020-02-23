using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    public string input;
    public GameObject playerText;
    public GameObject display;
    public GameObject TextBubble;

    public void StoreInput()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, true, false, false, false, "", 60);
        input = playerText.GetComponent<TextMeshProUGUI>().text;
        print(input);
        display.GetComponent<TextMeshProUGUI>().text = input;

        Instantiate(TextBubble, new Vector3(16.32171f, -433f, -156f), Quaternion.identity) ;
    }

}
