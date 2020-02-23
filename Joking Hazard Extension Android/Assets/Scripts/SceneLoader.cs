using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void backToMenu()
    {
        SFX.Playsound("back");
        SceneManager.LoadScene("Mainmenu");
    }

    public void loadCredits()
    {
        SFX.Playsound("back");
        SceneManager.LoadScene("Credits");
    }

    public void Disclaimer()
    {
        SFX.Playsound("back");
        SceneManager.LoadScene("Disclaimer");
    }

    public void playGame()
    {
        SFX.Playsound("back");
        SceneManager.LoadScene("EditorScene");
    }

    public void goToRules()
    {
        SFX.Playsound("back");
        SceneManager.LoadScene("Rules");
    }

    public void goToOption()
    {
        SFX.Playsound("back");
        SceneManager.LoadScene("Option");
    }
}
