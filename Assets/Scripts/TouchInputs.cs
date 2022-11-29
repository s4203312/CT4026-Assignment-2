using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInputs : MonoBehaviour
{
    // Input.GetTouch example.
    //
    // Attach to an origin based cube.
    // A screen touch moves the cube on an iPhone or iPad.
    // A second screen touch reduces the cube size.

    private Vector3 position;
    private float width;
    private float height;

    void Awake() {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update() {
        // Handle screen touches.
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved) {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                pos.y = (pos.y - height) / height;
                position = new Vector3(-pos.x, pos.y, 0.0f);

                // Position the cube.
                transform.position = position;
            }
        }
    }
}
