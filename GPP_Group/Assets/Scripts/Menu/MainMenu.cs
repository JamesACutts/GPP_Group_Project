using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string firstLevel;
    public GameObject optionScreen;
    public GameObject controlScreen;

    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }
    public void OpenOptions()
    {
        optionScreen.SetActive(true);
    }
    public void QuitOptions()
    {
        optionScreen.SetActive(false);
    }

    public void OpenControls()
    {
        controlScreen.SetActive(true);
    }
    public void QuitControls()
    {
        controlScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
