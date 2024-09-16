/*
John Chirayil
Assignment 3 - Challenge 2
Desc: This code will spawn the balls
falling down the wall within each 
interval.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public HealthSystem healthSystem;
    public DisplayScore displayScore;
    public bool gameOver = false;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomPrefabWithCoroutine());

        displayScore = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(startDelay);

        while (!gameOver)
        {
            SpawnRandomBall();

            // Make the spawn interval a random value between 3 seconds and 5 seconds 
            float randomTime = Random.Range(3.0f, 5.0f);

            yield return new WaitForSeconds(randomTime);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        if (!gameOver)
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            // declare a random int index variable which will incorporate that variable into the Instantiate call
            int ballIndex = Random.Range(0, ballPrefabs.Length);

            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        } 
    }

}
