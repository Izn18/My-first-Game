using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    // Stops Player Movement, after Collision with an Obstacle
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            Invoke("GameOverScene", 3f);
        }
    }

    void GameOverScene()
    {
        SceneManager.LoadScene(1);
    }
}
