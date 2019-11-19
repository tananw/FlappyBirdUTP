using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePipeScroll : MonoBehaviour
{
    public GameObject pipePrefab;
    public int numberOfPipes = 5;
    public float spawnRate = 3f;
    public float pipeMin = -1f;
    public float pipeMax = 3.5f;

    private Vector2 pipeSpawnPositon = new Vector2(-15f, -25f);
    private GameObject[] pipes;
    private float timeSinceLastSpawn;
    private float spawnXPos = 10f;
    private int currentPipe = 0;
    void Start()
    {
        pipes = new GameObject[numberOfPipes];
        for (int i = 0; i < numberOfPipes; i++)
        {
            pipes[i] = (GameObject)Instantiate(pipePrefab, pipeSpawnPositon, Quaternion.identity);
        }
    }


    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if(Controller.instance.gameOver == false && timeSinceLastSpawn >= spawnRate)
        {
            timeSinceLastSpawn = 0f;
            float spawnYPos = Random.Range(pipeMin, pipeMax);
            pipes[currentPipe].transform.position = new Vector2(spawnXPos, spawnYPos);
            currentPipe++;

            if (currentPipe >= numberOfPipes)
            {
                currentPipe = 0;
            }
        }
    }
}
