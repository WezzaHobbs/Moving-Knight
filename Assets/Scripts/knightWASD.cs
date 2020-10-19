using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightWASD : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    public Sprite firstSprite; //Default Sprite
    public Sprite secondSprite; //Default Jump Sprite
    public Sprite thirdSprite; //Flipped Sprite
    public Sprite fourthSprite; //Flipped Jump Sprite
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int xSpeed = 5;
        int ySpeed = 6;

        Vector3 velocity = rb.velocity;
        if (Input.GetKey("w"))
        {
            velocity.y = ySpeed;
        }
        else if (Input.GetKey("s"))
        {
            velocity.y = -ySpeed;
        }
        rb.velocity = velocity;

        if (Input.GetKey("a"))
        {
            velocity.x = -xSpeed;
        }
        else if (Input.GetKey("d"))
        {
            velocity.x = xSpeed;
        }
        rb.velocity = velocity;

        if ((velocity.y <= 0.2) && (velocity.x >= 0)) //Default Sprite
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = firstSprite;
        }
        else if ((velocity.y > 0.2) && (velocity.x >= 0)) //Default Jump Sprite
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = secondSprite;
        }
        else if ((velocity.y <= 0.2) && (velocity.x< 0)) //Flipped Sprite
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = thirdSprite;
        }
        else if ((velocity.y > 0.2) && (velocity.x <= 0)) //Flipped Jump Sprite
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = fourthSprite;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
    }
    
}

