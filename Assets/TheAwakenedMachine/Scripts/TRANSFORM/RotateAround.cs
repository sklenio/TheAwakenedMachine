//simple rotation around the object

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public int SpinRate;
    public Transform objectToOrbit;
    public void Update()
        {
            transform.RotateAround(objectToOrbit.position, Vector3.up, SpinRate * Time.deltaTime);
        }

}