using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private float groundLength;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        groundLength = boxCollider.size.x;
    }

    private void Update()
    {
        if (transform.position.x < -groundLength)
        {
            RespawnBackground();
        }
    }

    private void RespawnBackground()
    {
        Vector2 groundOffSet = new Vector2(groundLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
