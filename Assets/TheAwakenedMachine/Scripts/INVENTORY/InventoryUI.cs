//this script stores the information about 3 items collected in 3 text meshPro objects
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public AudioSource objectCollected;

    [SerializeField]
    private GameObject refToSharText; //a game object to count energy element item

    [SerializeField]
    private GameObject refToRepairText; //a game object to count repair gear item

    [SerializeField]
    private GameObject refToKeyText; //a game object to count key item

    private TextMeshProUGUI SharText; //a text object
    private TextMeshProUGUI RepairText;
    private TextMeshProUGUI KeyText;

    void Awake()
    {
        SharText = refToSharText.GetComponent<TextMeshProUGUI>(); //a game object possesses the property of a text storing item
        RepairText = refToRepairText.GetComponent<TextMeshProUGUI>();
        KeyText = refToKeyText.GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSharText(PlayerInventory playerInventory) //go to another script PlayerInventory
    {
        if (playerInventory != null) //check if the variable is more that zero
        SharText.text = playerInventory.NumberOfShar.ToString(); //changes the numeric data into string, a number becomes a text 
        objectCollected.Play(); //sound plays on collecting
        Debug.Log("InventoryUI.cs: ObjectedCollected sound is playing.");
    }

    public void UpdateRepairText(PlayerInventory playerInventory)
    {
        RepairText.text = playerInventory.NumberOfRepair.ToString();
        objectCollected.Play();
        Debug.Log("InventoryUI.cs: ObjectedCollected sound is playing.");
    }

        public void UpdateKeyText(PlayerInventory playerInventory)
    {
        KeyText.text = playerInventory.NumberOfKeys.ToString();
        objectCollected.Play();
        Debug.Log("InventoryUI.cs: ObjectedCollected sound is playing.");
    }
}
