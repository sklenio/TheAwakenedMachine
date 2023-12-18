using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPause : MonoBehaviour
{
    public AudioSource pauseSound;
    
    void OnTriggerEnter(Collider other) //simple and clean, plays sound when collider is triggered
    {
        pauseSound.Pause();
        Debug.Log("AudioOnTrigger.cs: Audio has been paused");
    }
    
}
