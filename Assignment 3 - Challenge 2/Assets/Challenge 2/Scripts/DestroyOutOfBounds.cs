/*
* John Chirayil
* Assignment 3 - Prototype 2
* Description: Destroy prefabs when out of bounds
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // Separating the food from the animals going out of bounds
        // Food goes out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //Animals go out of bounds
        if (transform.position.z < bottomBound)
        {
            // Debug.Log("Game Over!");

            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }
    }
}
