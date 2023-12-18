//going to use it later with moving lights and sounds


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTo : MonoBehaviour
{
//1 TELEPORT///////////////////////////////////////////////
   public Transform teleportPoint1;
   public Transform lerpTo;
   public float lerpModifier;

   void FixedUpdate()
   {
        transform.position = teleportPoint1.position;
        Vector3 a = transform.position;
        Vector3 b = lerpTo.position;
        transform.position = Vector3.Lerp(a, b, lerpModifier);
   }
////////////////////////////////////////////////////////////


//end//////////////////////////////////////////////////////
}
