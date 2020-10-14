using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightWASD : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    public Sprite firstSprite;
    public Sprite secondSprite;
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
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = secondSprite;
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
        if (velocity.y > 0)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = firstSprite;
        }
        if (velocity.y <= 0)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = secondSprite;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
    }
}
