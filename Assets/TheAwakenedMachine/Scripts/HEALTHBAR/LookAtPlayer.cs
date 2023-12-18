//HP Bar always turned to player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public new Transform camera;

    void LateUpdate()
    {
        Vector3 direction =  transform.position - camera.position; //turns the canvas to the opposite from the camera direction
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = rotation;
    //    transform.LookAt(camera);
    }
}
