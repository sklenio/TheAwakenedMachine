using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
//an instant teleport to coordinates
   public Transform instantTeleportTo;

   void FixedUpdate()
   {
      transform.position = instantTeleportTo.position;
   }

}
