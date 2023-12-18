//this script allows to heal using the repair gear activation

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepairActivation : MonoBehaviour
{
    [SerializeField]
     private GameObject refToRepairText; //an object storing the data about the repair gears

     private TextMeshProUGUI RepairText; // text format
     int NumberOfRepair; // numeral, number of keys
     public int healCount = 10; //the amount of heal, this part addresses the HealthManager.cs

    void Awake()
    {
        RepairText = refToRepairText.GetComponent<TextMeshProUGUI>(); //bestows an object the text format property
    }

    public void ActivateRepair()
    {
        NumberOfRepair = int.Parse(RepairText.text); // parse out the number of repair from the string variable

//        if (Input.GetKeyDown(KeyCode.Space)) 
//        {
            if (NumberOfRepair>0)  //and if the number is more than zero
            {
                StartCoroutine(FindObjectOfType<HealthManager>().Heal(healCount)); //then start the heal coroutine from another script HealthManager.cs
                Debug.Log("RepairActivation.cs: You have activated the repair. You have now " + NumberOfRepair + " repairs.");
            }
            Debug.Log("RepairActivation.cs: You have " + NumberOfRepair + " repairs.");
//        }
    }
}
