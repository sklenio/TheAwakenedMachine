// this script activates the drone attack animation on left click / A
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Animator animator; //introduce an animator on the scene
    public AudioSource playSound; //play that sound
    
    void Start()
    {
       animator = GetComponent<Animator>();  //enable Animator
    }

   
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //press this button
        {
            animator.SetBool("attack", true); //to start the attack animation
            playSound.Play();
            Debug.Log("Attack.cs: Animation on the Nano field is on.");
        }
        else if (Input.GetButtonUp("Fire1")) animator.SetBool("attack", false);
    }
}
