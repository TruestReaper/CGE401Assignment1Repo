/*
* John Chirayil
* Assignment 2 - Prototype 1
* Description: Initial code for trigger zone.
* Allows the player to earn points when passed through.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach this to player
public class TriggerZoneScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            // set the textbox to "You Win!"
            ScoreManager.score++;
        }
    }
}


