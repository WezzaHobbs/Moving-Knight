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
        if (Input.GetKey("w"))
        {
            float ySpeed = 16.0f;
            rb.velocity = new Vector3(ySpeed * 0, Time.deltaTime, 0);
        }
        if (Input.GetKey("a"))
        {
            float xSpeed = 5.0f;
            transform.position -= new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            float xSpeed = 5.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            float ySpeed = 8.0f;
            transform.position -= new Vector3(ySpeed * 0, Time.deltaTime, 0);
        }
    }
}
