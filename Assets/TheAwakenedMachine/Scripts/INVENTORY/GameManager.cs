//The inventory array is stored here, which assigns the item sprite to inventory cells

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image[] inImages; //let an array for images be
    public Sprite[] spr; //let another array with sprites be

//this part is for buttons

    public void ChangeSharSprite() //the cell image for the energy element Shar will be taken from this sprite
    {
        inImages[0].sprite = spr[0];
    }

    public void ChangeRepairSprite() //the cell image for the repair gear will be taken from this sprite
    {
        inImages[1].sprite = spr[1];
    }

    public void ChangeKeySprite() //the cell image for the key will be taken from this sprite
    {
        inImages[2].sprite = spr[2];
    }

// this part is for picking up items by triggering their collider and checking the tag label.

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "energyelement")
        {
            inImages[0].sprite = spr[0];
        }
        if (other.tag == "repair")
        {
            inImages[1].sprite = spr[1];
        }
        if (other.tag == "key")
        {
            inImages[2].sprite = spr[2];
        }
    }
    

}
