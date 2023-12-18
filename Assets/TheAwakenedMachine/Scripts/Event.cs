using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Event : MonoBehaviour
{
public UnityEvent onItemCollected;
    [SerializeField]
    private void Grab()
    {
        onItemCollected.Invoke();
    }
}
