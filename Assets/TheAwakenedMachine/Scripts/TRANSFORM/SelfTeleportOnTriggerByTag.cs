//that script allows to teleport something or someone when the player triggers the collider with this script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class SelfTeleportOnTriggerByTag : MonoBehaviour
{
   public Transform teleportPoint;

// If the Player triggers the collider, the object instantly teleports to the teleportPoint position
   public void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        transform.position = teleportPoint.position;
        Debug.Log("TeleportTagOnTrigger.cs: You have teleported the object to the teleportPoint.");
    }
}

}
