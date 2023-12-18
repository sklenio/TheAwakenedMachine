using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class EndGameScreen : MonoBehaviour
{
    public AudioSource playSound; //here we can put the winning sound

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //starts the EndGame scenario if object tagged as Player touches this collider
        {
            EndGame();
            Debug.Log("EndGameScreen.cs: You have finished the stage. Press RESTART to play again.");
        }
    }

    public void EndGame()
    {
        playSound.Play(); //winning sound is playing
        Debug.Log("EndGameScreen.cs: Winning Sound is playing");

        StartCoroutine(LoadEndGameScreen());
        Debug.Log("EndGameScreen.cs: End Game Screen is loading asynchroniously");
    }

    IEnumerator LoadEndGameScreen()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("4 EndGameScreen"); //restarts the stage from the beginning, all progress is lost

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void StageIsClear()
    {
        StartCoroutine(LoadStage1Screen());
        Debug.Log("EndGameScreen.cs: Stage1 is loading asynchroniously");
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
        Debug.Log("EndGameScreen.cs: Application has quit.");
    }
}
