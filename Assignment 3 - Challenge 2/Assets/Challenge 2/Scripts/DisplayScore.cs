/*
* John Chirayil
* Assignment 3 - Prototype 2
* Description: This will display the score system in the game,
* as well as managing the score system
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    public bool gameOver = false;
    public GameObject youWinText;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 5)
        {
            gameOver = true;
            youWinText.SetActive(true);

            FindObjectOfType<SpawnManagerX>().gameOver = true;

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
