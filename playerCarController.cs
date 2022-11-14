using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public int moveSpeed = 1;
    public int turnSpeed = 2;
    private int i = 100;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Drive();
    }



    public void Drive()
    {
        if (Input.GetKey(KeyCode.W))
            {
               rb.AddForce(transform.forward * moveSpeed);
               moveSpeed ++;
            }
        else if (Input.GetKey(KeyCode.S))
            {
               rb.AddForce(-transform.forward * moveSpeed);
                
            }
        else if (Input.GetKey(KeyCode.A))
            {
               transform.Rotate(Vector3.up, -turnSpeed *moveSpeed * Time.deltaTime);
            }
        else if (Input.GetKey(KeyCode.D))
            {
               transform.Rotate(Vector3.up, turnSpeed *moveSpeed* Time.deltaTime);
            }
         else if(Input.GetKey(KeyCode.Space))
            {
                while (i >= 100)
                {
                   moveSpeed --;
                   i--;
                }
            }
           else
            {
                moveSpeed = 1;
            }
        }
            
    }
}
