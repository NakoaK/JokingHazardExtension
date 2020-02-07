using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void backToMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void loadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Disclaimer()
    {
        SceneManager.LoadScene("Disclaimer");
    }

    public void playGame()
    {
        SceneManager.LoadScene("EditorScene");
    }

    public void goToRules()
    {
        SceneManager.LoadScene("Rules");
    }
}
