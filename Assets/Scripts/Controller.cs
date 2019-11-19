using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public static Controller instance;
    public Text scoreText;
    public bool gameOver = false;
    public GameObject gameOverText;
    public GameObject gameOverScreen;
    public AudioSource bgMusic;
    public static bool isPlaying = false;

    private int score = 0;

    void Awake()
    {
        if (!isPlaying)
        {
            bgMusic.Play();
            isPlaying = true;
        }
        DontDestroyOnLoad(bgMusic);
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Update()
    {
        if (gameOver && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void playerScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void playerDied()
    {
        gameOver = true;
        gameOverText.SetActive(true);
        gameOverScreen.gameObject.SetActive(true);
    }
}