//this script allows to pick up energy elements and book their number through another script PlayerInventory

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shar : MonoBehaviour
{
  /* this is the old section
    private void OnTriggerEnter(Collider other)
    {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
            Debug.Log("Shar.cs: You have entered the trigger zone of the energy element Shar.");

            if (playerInventory != null)
            {
                playerInventory.SharCollected();
                gameObject.SetActive(false);
                Debug.Log("Shar.cs: You have picked up the energy element Shar.");
            }
            
    }
*/

       public void TriggerSharCollected(Collider other)
    {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
            Debug.Log("Shar.cs: You have entered the trigger zone of the energy element Shar.");

            if (playerInventory != null) //if the variable is not empty
            {
                playerInventory.SharCollected(); //then implement the scenario of collecting the object
            //    gameObject.SetActive(false);
                Debug.Log("Shar.cs: You have picked up the energy element Shar.");
            }
            
    }
}
