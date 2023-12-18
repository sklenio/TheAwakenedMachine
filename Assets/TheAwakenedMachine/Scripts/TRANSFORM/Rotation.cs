//another simple rotation
//proved to be poorly adjusted
//keeping it for future 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float degreesPerSecondX = 20;
    public float degreesPerSecondY = 20;
    public float degreesPerSecondZ = 20;

    public void Update()
    {
        transform.Rotate(new Vector3(degreesPerSecondX, degreesPerSecondY, degreesPerSecondZ) * Time.deltaTime);
    } 
}
