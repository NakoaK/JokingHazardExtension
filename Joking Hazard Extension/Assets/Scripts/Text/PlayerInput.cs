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

    public void StoreInput()
    {
        input = playerText.GetComponent<TextMeshProUGUI>().text;
        print(input);
        display.GetComponent<TextMeshProUGUI>().text = input;
    }

}
