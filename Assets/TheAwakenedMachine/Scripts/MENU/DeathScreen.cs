//This script loads Death Screen from the GameOver Scene, plays the death audio and allows to restart the Stage1.
// !! add additive scene to every scene with the players rig !!
// SceneManager.LoadScene("Persistent Scene", LoadSceneMode.Additive); // the players rig travels throughout all scenes in the game!
// загружается вместе с каждой сценой, которая в свою очередь выгружается при переходе на следующую, 
// выгрузка переменных с сохранённым прогрессом в статичный непривязанный скрипт происходит здесь!
// SceneManager.UnloadScene(SceneManager.GetSceneAt(0).name); // unloads the first scene

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI; //progress bar

public class DeathScreen : MonoBehaviour
{
    public AudioSource playSound; //here we can put the death sound
    public Slider progressBar;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name); //shows what has triggered the death line
        if (other.gameObject.CompareTag("Player")) //the Death scenario invokes if the triggering object has a Player tag
            {
                Death();
                Debug.Log("DeathScreen.cs: You died. Press AGAIN to restart.");
            }
    }

    public void Death()
    {
        playSound.Play(); //death sound is playing
        Debug.Log("DeathScreen.cs: Death Sound is playing");

        StartCoroutine(LoadDeathScreen()); //launches the death coroutine on Death event
        Debug.Log("DeathScreen.cs: Death Scene is loading asynchroniously");
    }

    IEnumerator LoadDeathScreen()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("3 GameOverScreen"); //loads the death screen

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            //progress bar
            yield return null;
        }
    }

    public void Reboot()
    {
        StartCoroutine(LoadStage1Screen());
        Debug.Log("DeathScreen.cs: Stage1 is loading asynchroniously");
    }

    IEnumerator LoadStage1Screen()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("2 Stage1"); //restarts the stage from the beginning, all progress is lost

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            progressBar.value = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            yield return null;
        }
    }
}
