using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.WSA.Input;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    private float restartTimer = 3f;

    public GameObject finishedUi;

    public void LevelComplete()
    {
        finishedUi.SetActive(true);
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

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}