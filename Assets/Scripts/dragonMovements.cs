using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonMovements : MonoBehaviour
{
    int timer = 0;
    int xDirection;
    void Start()
    {
        xDirection = 3;
    }

    void Update()
    {
        timer++;
        if (timer > 120)
        {
            timer = 0;
            xDirection = -xDirection;
        }
        transform.position += new Vector3(xDirection * Time.deltaTime, 0, 0);
    }
}


