//Best for high speed pulsing objects

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToManyPoints : MonoBehaviour
{
  [SerializeField] GameObject[] waypoints; //an array of coordinates
  int currentWaypointIndex = 0;
    void Update()
    {
      if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f) //if we've reached this point in the array
      {
        currentWaypointIndex++; //then instantly go the next one
        if (currentWaypointIndex >= waypoints.Length) //if we've reached the last point
        {currentWaypointIndex = 0;} //then go to beginning
      }
      // transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
      transform.position = waypoints[currentWaypointIndex].transform.position; //then teleport to the coordinate point
    }
}

