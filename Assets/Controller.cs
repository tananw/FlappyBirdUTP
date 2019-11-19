using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public static Controller instance;
    public Text scoreText;

    private int score = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void BirdScored()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}