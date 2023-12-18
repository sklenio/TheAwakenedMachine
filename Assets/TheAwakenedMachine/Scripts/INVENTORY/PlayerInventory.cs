//this script updates the count for inventory items

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfShar {get; private set;} //a variable to store the numeric data
    public UnityEvent<PlayerInventory> OnSharCollected; //an event for energy element collection
   
    public void SharCollected()
    {
        NumberOfShar++; //the number is updated
        OnSharCollected.Invoke(this); //implement changes
    }
    
    public int NumberOfKeys {get; private set;}
    public UnityEvent<PlayerInventory> OnKeysCollected;
   
    public void KeysCollected()
    {
        NumberOfKeys++;
        OnKeysCollected.Invoke(this);
    }

    public int NumberOfRepair {get; private set;}
    public UnityEvent<PlayerInventory> OnRepairCollected;
   
    public void RepairCollected()
    {
        NumberOfRepair++;
        OnRepairCollected.Invoke(this);  
    }
}
