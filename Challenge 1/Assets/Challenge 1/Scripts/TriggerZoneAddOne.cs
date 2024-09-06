/*
* John Chirayil
* Assignment 2 - Challenge 1
* Description: Increases score when passing through trigger zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddOne : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
