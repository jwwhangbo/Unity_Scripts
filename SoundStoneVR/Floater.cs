﻿// Floater v0.0.2
// by Donovan Keith
//
// [MIT License](https://opensource.org/licenses/MIT)

using System;
using UnityEngine;
using System.Collections;

// Makes objects float up & down while gently spinning.
public class Floater : MonoBehaviour
{
    // User Inputs
    public int degreesPerSecond = 15;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        System.Random rand = new System.Random();

        // Spin object around Y-Axis
        //transform.Rotate(new Vector3(Time.deltaTime * rand.Next(-degreesPerSecond, degreesPerSecond), Time.deltaTime * rand.Next(-degreesPerSecond, degreesPerSecond), Time.deltaTime * rand.Next(-degreesPerSecond, degreesPerSecond)), Space.World);
        transform.Rotate(new Vector3(Time.deltaTime * rand.Next(degreesPerSecond), Time.deltaTime * rand.Next(degreesPerSecond), Time.deltaTime * rand.Next(degreesPerSecond)), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}
