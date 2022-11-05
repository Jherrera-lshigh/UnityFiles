using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
NOTE To Self:
Add velocity to the car to add inertia, so the car does not 
just stop when the player stops pressing the key.
*/



public class playerControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 1.5f;
    public Vector3 lastPosition = Vector3.zero;
    void Update()
    {
        //move forwrd
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        //move backward
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        //turn left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * moveSpeed*Time.deltaTime);
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        //turn right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * moveSpeed*Time.deltaTime);
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        //handbrake
        if(Input.GetKey(KeyCode.Space))
        {
            for(int i=5; i>0; i--)
            {
                moveSpeed -=1f;
                turnSpeed -=0.001f;
            }
        }
        else
        {
            moveSpeed = 5.0f;
            turnSpeed = 1.5f;
        }
        //boost
        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 10;
        }
        else
        {
            moveSpeed = 5;
        }
        
    }
}
