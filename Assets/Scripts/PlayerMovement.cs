﻿using UnityEngine;
using UnityEngine.SceneManagement;

// Class that is responsible to manage the Player Movement
public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public PlayerMovement movement;

    public float movementSpeed = 1f;
    public float steeringSpeed = 100f;

    // Fixed Update is used for Physics stuff
    private void FixedUpdate()
    {
        // Add constant movement in z
        rb.AddForce(0, 0, movementSpeed * Time.deltaTime);

        
        // Testing the Speed of the Player
        //if (Input.GetKey("w"))
        //{
        //    rb.AddForce(0,0,steeringSpeed * Time.deltaTime, ForceMode.VelocityChange);
        //}
        
        // Steer to the right by pressing the "D" button
        if (Input.GetKey("d"))
        {
            rb.AddForce(steeringSpeed * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        
        // Steer to the left by pressing the "A" button
        if (Input.GetKey("a"))
        {
            rb.AddForce(-steeringSpeed * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        // Check if the Player is still on the Ground
        // If not the GameOverScene is called
        if (rb.position.y < 0.75f)
        {
            movement.enabled = false;
            Invoke("GameOverScene", 3f);
        }
    }
    
    // Changes the Scene to the Game Over Screen
    void GameOverScene()
    {
        SceneManager.LoadScene(1);
    }
}
