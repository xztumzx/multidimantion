using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepos : MonoBehaviour
{
    public Transform cube; // Drag the Cube object in the Inspector
    public float leftPositionX = -0.5f; // Position on the left relative to Player
    public float rightPositionX = 0.5f; // Position on the right relative to Player

    void Start()
    {
        // Set initial position of the Cube to the left
        Vector3 initialPosition = cube.localPosition;
        initialPosition.x = leftPositionX;
        cube.localPosition = initialPosition;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Move Cube to the right position
            Vector3 position = cube.localPosition;
            position.x = rightPositionX;
            cube.localPosition = position;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            // Move Cube to the left position
            Vector3 position = cube.localPosition;
            position.x = leftPositionX;
            cube.localPosition = position;
        }
    }
}
