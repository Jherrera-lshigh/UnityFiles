using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpAmount;
    bool left;
    bool right;
    bool up;
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        left = Input.GetKey(KeyCode.A);
        right = Input.GetKey(KeyCode.D);
        up = Input.GetKey(KeyCode.W);

        if (left)
        {
            transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);
        }

        if (right)
        {
            transform.Translate(Vector2.right * speed * Time.fixedDeltaTime);
        }

        if (up) 
        {
            transform.Translate(Vector2.up * jumpAmount * Time.fixedDeltaTime);
        }
    }
}
