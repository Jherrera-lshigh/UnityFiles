using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float turnSpeed = 2.5f;
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
            moveSpeed += 0.01f;
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
                moveSpeed -= 0.1f;
                i--;
            }
        }
        else
        {
            moveSpeed = 1.0f;
        }
        
    }
}
