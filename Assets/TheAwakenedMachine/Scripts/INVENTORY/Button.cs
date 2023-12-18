//this script allows to use button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
public GameObject objectActivator;

public void whenButtonClicked()
{
if (objectActivator.activeInHierarchy == true)
objectActivator.SetActive(false);
else
objectActivator.SetActive(true);
}
}
