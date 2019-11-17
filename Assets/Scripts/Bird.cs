using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementSpeed;
    public float jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        if(transform.position.y > 18 || transform.position.y < -19)
        {
            Death();
        }
    }

    public void Death()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
    }
}
