/*
* John Chirayil
* Assignment 2 - Challenge 1
* Description: The player will lose if their plane
* flies out of the flyzone.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseIfOuttaBounds : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
        if (transform.position.y < -50)
        {
            ScoreManager.gameOver = true;
        }

    }
}
