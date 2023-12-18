//this script allows to call an elevator

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ElevatorControl : MonoBehaviour 
{
    public float speed;
    public bool goingDown; //check if the elevator is going down or up
    public Transform targetDown; //the first floor
    public Transform targetUp; //the second floor
 
    public void CallElevator()
    {
        goingDown = !goingDown;
    }

    public void FixedUpdate()
    {
        if(goingDown == true) //if the elevator is on the second floor, then it is able to go down
        {
            transform.position = Vector3.MoveTowards(transform.position, targetDown.position, speed * Time.deltaTime); //here are the coordinates for the first floor
        //    Debug.Log("MoveTo.cs: Elevator is moving down");
        }

        else if(goingDown == false) //if the elevator is on the first floor, then it is able to go up
        {
                transform.position = Vector3.MoveTowards(transform.position, targetUp.position, speed * Time.deltaTime); //here are the coordinates for the second floor
        //        Debug.Log("MoveTo.cs: Elevator is moving up");
        }
    }
}