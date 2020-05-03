using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(2);
    }
    
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
