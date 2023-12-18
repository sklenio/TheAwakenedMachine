//this script counts repair gears 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair : MonoBehaviour
{
    private bool isHoldingRepair; //a bool for holding the object
    private Collider refToOther; //a booking of the number will be set on this object
    
    private void OnTriggerEnter(Collider other) //if the repair gear's collider is triggered
    {
        isHoldingRepair = true; //then set the holder's value to true
        refToOther = other; //a link betweeen objects
        Debug.Log("Repair.cs: You have triggered the repair collider on entering it.");
    }

    void OnTriggerExit(Collider other)
    {
        isHoldingRepair = false;
        refToOther = null;
        Debug.Log("Repair.cs: You have exited the trigger zone.");
    }

    void Update() {
        if (isHoldingRepair){ //if the holder bool is true

            PlayerInventory playerInventory = refToOther.GetComponent<PlayerInventory>(); //and let refToOther variable access the collection update scenario
                                                                                            //and let refToOther variable access the collection update scenario
            if (playerInventory != null) //if the variable is not empty
            {
                playerInventory.RepairCollected(); //then launch the RepairCollected scenario
                gameObject.SetActive(false); //the object itself disappears from the scene
                Debug.Log("Repair.cs: You have obtained the Repair!");
            }
        }


    }
}
