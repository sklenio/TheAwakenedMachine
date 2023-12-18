using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnTrigger : MonoBehaviour
{
    public AudioSource playSound;
    
    void OnTriggerEnter(Collider other) //simple and clean, plays sound when collider is triggered
    {
        playSound.Play();
        Debug.Log("AudioOnTrigger.cs: Audio is playing");
    }
    
}
