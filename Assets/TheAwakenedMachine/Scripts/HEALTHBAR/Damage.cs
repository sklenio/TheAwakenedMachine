//this script sets the damage value dealt to the player by an enemy when triggering the enemy's collider.
//the script hangs on the enemy, the dd in this case

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageCount = 10; //damage -10 HP player

    private void OnTriggerEnter(Collider other) //when someone other is triggering the enemy's collider 
    {
        if (other.CompareTag("Player")) //and if that other someone has a tag "Player"
            {
                StartCoroutine(FindObjectOfType<HealthManager>().Damage(damageCount)); //then go to script HealthManager 
                                                                                       //and proceed the coroutine that deals the damage on the Player
                Debug.Log("Damage.cs: The Player has triggered the damage dealing object.");
            }
    
    }
}
