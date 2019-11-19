using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject groundLoop;
    void Start()
    {
    }

    void Update()
    {
    }

    void OnBecameInvisible()
    {
        transform.Translate(80f, 0, 0);
    }
}
