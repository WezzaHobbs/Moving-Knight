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
        int xSpeed = 5;
        int ySpeed = 5;
        bool isGrounded = true;

        Vector3 velocity = rb.velocity;
        if (Input.GetKey("w") && isGrounded == true)
        {
            velocity.y = ySpeed;
        }
        rb.velocity = velocity;
        if (Input.GetKey("s"))
        {
            velocity.y = -ySpeed;
        }
        rb.velocity = velocity;
        if (Input.GetKey("a"))
        {
            velocity.x = -xSpeed;

        }
        rb.velocity = velocity;
        if (Input.GetKey("d"))
        {
            velocity.x = xSpeed;
        }
        rb.velocity = velocity;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
    }
}
