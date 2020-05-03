using UnityEngine;
using UnityEngine.SceneManagement;

// Behaviour for Collisions
public class PlayerCollision : MonoBehaviour
{
    
    // Necessary to disable Player movement after collision
    public PlayerMovement movement;
    //public WallMovement movement;

    // Stops Player Movement and calls the GameOverScene Method, after Collision with an Obstacle
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            Invoke("GameOverScene", 3f);
        }
        
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            Invoke("GameOverScene", 3f);
        }
    }

    // Changes the Scene to the GameOver Scene
    void GameOverScene()
    {
        SceneManager.LoadScene(1);
    }
}
