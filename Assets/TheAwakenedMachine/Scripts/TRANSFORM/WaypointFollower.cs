//this script allows an object to follow the coordinate point and route in loops

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
  [SerializeField] GameObject[] waypoints; //an array with coordinates storage
  int currentWaypointIndex = 0; //the beginning point
  [SerializeField] float speed = 1f;
    void Update()
    {
      if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f) //if the coordinate is reached
      {
        currentWaypointIndex++; //then go to the next point
        if (currentWaypointIndex >= waypoints.Length) //and if there are no other points
        {
          currentWaypointIndex = 0; //then go to beginning
        }
      }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime); //and move the object to the point
    }
}
