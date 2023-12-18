//this script manages the key status and its booking upon collection

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private bool isHoldingKey; //whether the key is being held or not
    private Collider refToOther;
    [SerializeField]
    private GameObject keyDropPrefab; //another object to be granted afterwards
    
    private void OnTriggerEnter(Collider other) //when collider is entered
    {
        isHoldingKey = true; //the key holder sets on
        refToOther = other;
        Debug.Log("Keys.cs: You have triggered the key collider on entering it.");
    }

    void OnTriggerExit(Collider other) //when collider is exited
    {
        isHoldingKey = false; //the key holder sets off
        refToOther = null;
        Debug.Log("Keys.cs: You have exited the trigger zone.");
    }

    void Update() {
        if (isHoldingKey){ //if the key holder is set on

            PlayerInventory playerInventory = refToOther.GetComponent<PlayerInventory>(); //then go to another script PlayerInventory.cs
                                                                                        //and let the variable refToOther access it
            if (playerInventory != null) //if the variable playerInventory is not empty
            {
                playerInventory.KeysCollected(); //then launch the KeysCollected scenario
                gameObject.SetActive(false); //the objects itself disappears on triggering its collider
                Instantiate(keyDropPrefab, transform.position, transform.rotation); //a bit of holy creation happens here as well
                Debug.Log("Key: You have obtained the key!");
            }
        }

    }
}
