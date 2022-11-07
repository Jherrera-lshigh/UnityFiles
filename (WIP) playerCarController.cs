using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float turnSpeed = 2.5f;
    private int i = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            rb.AddForce(transform.forward * moveSpeed);
            while (i<=100)
            {
                moveSpeed += 0.1f;
                i++;
            }
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * moveSpeed);
            while (i >= 100)
            {
                moveSpeed -= 0.1f;
                i--;
            }
        }
    }
}
