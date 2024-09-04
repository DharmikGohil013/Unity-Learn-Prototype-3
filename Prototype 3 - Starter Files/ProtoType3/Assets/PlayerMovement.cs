using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 5f;  // Speed for moving forward
    public float turnSpeed = 100f; // Speed for turning

    void Start()
    {
        // Get the Animator component attached to the Player GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool Walking = false; // A flag to check if the player should be walking

        // Check if the "W" key is pressed for moving forward
        if (Input.GetKey(KeyCode.W))
        {
            // Move the player forward
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            Walking = true; // Player is walking
        }

        // Check if the "A" key is pressed for turning left
        if (Input.GetKey(KeyCode.A))
        {
            // Rotate the player to the left
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            Walking = true; // Player is walking (turning is considered walking)
        }

        // Check if the "D" key is pressed for turning right
        if (Input.GetKey(KeyCode.D))
        {
            // Rotate the player to the right
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            Walking = true; // Player is walking (turning is considered walking)
        }

        // Update the animator based on whether the player is walking
        animator.SetBool("Walking", Walking);
    }
}
