using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDeathZoneX : MonoBehaviour
{
    //movement speed in units per second
    public float movementSpeed;

    void FixedUpdate()
    {
        //Checking the position of the object along the x axis, if greater or equal to 7.5 makes the movement speed -1f
        if (transform.position.x >= 7.5)
        {
            movementSpeed = -5f;
        }
        //Checking the position of the object along the x axis, if less than or equal to -5 makes the movement speed 1f
        if (transform.position.x <= -5)
        {
            movementSpeed = 5f;
        }
        //Moves the object along the X axis, direction changes based on positive or negative movement speed. 
        transform.Translate(movementSpeed * Time.deltaTime, 0, 0);

    }

}