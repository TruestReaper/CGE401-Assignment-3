/*
John Chirayil
Assignment 3 - Challenge 2
Desc: This code will allow the dog
to move alongside the ground.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
