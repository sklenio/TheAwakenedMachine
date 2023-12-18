//this script sets the player's health and death

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int playerHealth = 100; //player has 100 HP
    public static bool gameOver; // death case
    public TextMeshProUGUI playerHealthText; 
    public GameObject damageOverlay; //pain veil, appears shortly in front of the camera
    public AudioSource damageSound;
    
    void Start()
    {
        gameOver = false; //
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthText.text = "" + playerHealth;
        if (gameOver) //if gameover bool is true then
        {
            SceneManager.LoadScene("3 GameOverScreen"); //the GameOverScene is loading
        }
    }
    public IEnumerator Heal (int healCount) //this coroutine heals the player
    {
        playerHealth += healCount;
        yield return new WaitForSeconds(.5f);
    }

    public IEnumerator Damage (int damageCount) //this coroutine deals damage on player
    {
        playerHealth -= damageCount;
        damageSound.Play(); //plays the sound of taking damage
        damageOverlay.SetActive(true); //show the veil


        if (playerHealth <=0) //if player's health reaches 0
        {
            gameOver = true; //the player dies
        }

        yield return new WaitForSeconds(.5f);
        damageOverlay.SetActive(false);
    }
}
