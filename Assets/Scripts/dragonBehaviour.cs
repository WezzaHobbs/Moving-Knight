using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonBehaviour : MonoBehaviour
{
    int timer = 0;
    int xDirection;
    // Start is called before the first frame update
    void Start()
    {
        xDirection = 3;
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if(timer>120)
        {
            timer = 0;
            xDirection = -xDirection;
        }
        transform.position += new Vector2(xDirection * Time.deltaTime, 0);
    }
}
