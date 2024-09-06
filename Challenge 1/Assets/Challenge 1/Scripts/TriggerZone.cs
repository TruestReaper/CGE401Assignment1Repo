/*
* John Chirayil
* Assignment 2 - Challenge 1
* Description: Initial code for trigger zone.
* Allows the player to earn points when passed through.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            // set the textbox to "You Win!"
            ScoreManager.score++;
        }
    }
}
