/*
* John Chirayil
* Assignment 2 - Prototype 1
* Description: The player will lose if their vehicle
* falls of the road.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
