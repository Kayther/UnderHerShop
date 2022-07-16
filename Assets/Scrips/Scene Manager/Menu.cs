
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GoToGame()
    {
        SFX.Click();
        if (VariableManager.firstPlay == false)
        {
            SceneManager.LoadScene("Intro");
        }
        else
        {
            if (VariableManager.dayCount >= 20)
            {
                SceneManager.LoadScene("Finale");
            }
            else
            {
                SceneManager.LoadScene("Shop");
            } 
        }
    }

    public void Close()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SFX.Click();
        SceneManager.LoadScene("Menu");
    }
    public void GoToHome()
    {
        SFX.Click();
        SceneManager.LoadScene("Home");
    }
}
