using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyActivation : MonoBehaviour 
{

//    [SerializeField]              //used to switch elevator, don't use it anymore 
//    private GameObject elevator; //now with the second version of the elevator
    [SerializeField]
    private GameObject wall; //a door to open
    
    // this part should help access the NumberOfKeys from the PlayerInventory.cs
    [SerializeField]
     private GameObject refToKeyText; //an object that counts the keys, part of the inventory

     private TextMeshProUGUI KeyText; //number of keys in text format
     int NumberOfKeys;  //number of keys in numeric format

        void Awake()
        {
            KeyText = refToKeyText.GetComponent<TextMeshProUGUI>(); //gameobject has been recognized as text format
        //    elevator.SetActive(false);
        }

        void OnTriggerEnter() //when triggering the object's collider
        {
            NumberOfKeys = int.Parse(KeyText.text); //parse out the numeral from the text so we'd know how many keys we got in inventory
            Debug.Log("KeyActivation.cs:: You need a key to activate the door. You have " + NumberOfKeys + " keys.");
        }

        void OnTriggerStay()
        {
            if (NumberOfKeys>0)  //and if the keys number is more than zero
            {
             //   elevator.SetActive(true);
                wall.SetActive(false); //then the obstacle simply disappears
                Debug.Log("KeyActivation.cs: You have activated the elevator. The wall is open.");
            }
        }

        
}



