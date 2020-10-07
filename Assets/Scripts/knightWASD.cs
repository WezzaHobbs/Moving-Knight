using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightWASD : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
        if (Input.GetKey("w"))
        {
            velocity.y = 16;
            Debug.Log("W key");
            rb.velocity = new Vector2(0, velocity);
        }
        if (Input.GetKey("a"))
        {
            velocity.x = -16;
            rb.velocity = new Vector2(velocity, 0);
        }
        if (Input.GetKey("d"))
        {
            velocity.x = 16;
            rb.velocity = new Vector2(velocity, 0);
        }
        if (Input.GetKey("s"))
        {
            velocity.y = -16;
            rb.velocity = new Vector2(0, velocity);
        }
    }
}
