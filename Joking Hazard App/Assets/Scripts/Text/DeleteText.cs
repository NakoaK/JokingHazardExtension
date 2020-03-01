using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeleteText : MonoBehaviour
{
    public GameObject playerText;
    public string resetText = "";

    public bool textAlreadyCreated = false;

    public void textCreated()
    {
        textAlreadyCreated = true;
    }

    public void deleteText()
    {
        if (textAlreadyCreated)
        {
            playerText.GetComponent<TextMeshProUGUI>().text = resetText;
        }

    }

   


}
