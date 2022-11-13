using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {
    public Transform[] target;
    public float speed;
    private int current;

    // Update is called once per frame
    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector2 pos = Vector2.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
    }
}
