/*
* John Chirayil
* Assignment 2 - Challenge 1
* Description: spins the propeller on plane
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    private float propellerSpeed = 1000;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);
    }
}
