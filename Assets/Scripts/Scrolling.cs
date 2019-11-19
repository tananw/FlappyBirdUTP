using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        rigid2D.velocity = new Vector2(Controller.instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.instance.gameOver == true)
        {
            rigid2D.velocity = Vector2.zero;
        }
    }
}
