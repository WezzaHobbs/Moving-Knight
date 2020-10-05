using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonArrows : MonoBehaviour
{
    public int lives2 = 1;
    void Start()
    {

    }

    void Update()
    {
    float xSpeed = 4.0f;
    float ySpeed = 4.0f;
        if (Input.GetKey("right"))
        {
            xSpeed = 4.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            ySpeed = 4.0f;
            transform.position += new Vector3(ySpeed * 0, Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))
        {
            xSpeed = 4.0f;
            transform.position -= new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            ySpeed = 4.0f;
            transform.position -= new Vector3(ySpeed * 0, Time.deltaTime, 0);
        }
        if (Input.GetKey("o"))
        {
            lives2 = lives2 + 1;
        }
        if (Input.GetKey("p"))
        {
            lives2 = 0;
        }
    }
}

