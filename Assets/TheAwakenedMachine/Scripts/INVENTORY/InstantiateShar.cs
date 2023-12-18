//this script allows to create a prefabed item on event

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateShar : MonoBehaviour
{

    [SerializeField]
    private GameObject dropPrefab; //that item will be created

    public void BeginInstantiateShar()
    {
        Instantiate(dropPrefab, transform.position, transform.rotation); //creation with the coordinates
        Debug.Log("InstantiateShar.cs: The machine has created an item." + dropPrefab);
    }
}
