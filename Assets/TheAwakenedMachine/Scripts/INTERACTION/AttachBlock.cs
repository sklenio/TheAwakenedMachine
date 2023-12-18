using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachBlock : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Kollar om det var spelaren som kolliderade med plattformen
        if (other.gameObject.CompareTag("Player"))
        {
            // Om det var det så bind spelaren att bli en child
            // till detta objekts transform
            other.gameObject.transform.SetParent(transform);
            Debug.Log("AttachBlock.cs: Player were adopted by the object");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.SetParent(null);
            Debug.Log("AttachBlock.cs: Player were unparented by the object.");

        }

    }
}