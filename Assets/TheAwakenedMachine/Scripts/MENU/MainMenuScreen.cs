using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuScreen : MonoBehaviour
{
    public void MainMenu()
    {
        StartCoroutine(LoadMainMenu());
        Debug.Log("MainMenuScreen.cs: Main Menu Screen is loading asynchroniously");
    }

    IEnumerator LoadMainMenu()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("1 Main Menu"); // The Application loads the Scene in the background as the current Scene runs.

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void ResumeStage1()
    {
        StartCoroutine(LoadStage1Screen());
        Debug.Log("MainMenuScreen.cs: Stage1 is loading asynchroniously");
    }
    
    IEnumerator LoadStage1Screen()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("2 Stage1"); //restarts the stage from the beginning, all progress is lost

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("MainMenuScreen.cs: Application has quit.");
    }
}
