using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public int speed;
    public int jumpAmount;
    public Rigidbody2D rb;
    bool isgrounded;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * speed);
        }
        if(Input.GetKey(KeyCode.Space) && (GetComponent<BoxCollider2D>().IsTouchingLayers(LayerMask.NameToLayer("Floor"))))
        {
            rb.AddForce(new Vector2(0,jumpAmount), ForceMode2D.Impulse);
        }

    }
}

