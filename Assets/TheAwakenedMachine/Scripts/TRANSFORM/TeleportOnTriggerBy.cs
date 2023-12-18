using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnTriggerBy : MonoBehaviour
{
 //public GameObject teleportPoint;

    public Transform teleportTo; //where teleport
    public Transform player; //whom teleport

    void OnTriggerEnter(Collider other) //when the collider is triggered
        {
            if (other.gameObject.CompareTag("Player")) //if the intruder has a Player tag
                {
                    player.position = teleportTo.position; //then teleport the intruder somewhere
                    Debug.Log("TeleportOnTriggerByTag.cs: You have been teleported");
                }
        } 
}
