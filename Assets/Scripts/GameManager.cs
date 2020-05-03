using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.WSA.Input;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    private float restartTimer = 3f;

    public void finished()
    {
        Debug.Log("Finished!");
    }

    public void EndGame()
    {
        if (gameOver == false)
        {
            Debug.Log("Game Over");
            gameOver = true;
            Invoke("Restart", restartTimer);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}