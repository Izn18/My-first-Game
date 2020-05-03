using UnityEngine;
using UnityEngine.SceneManagement;

// Respüonsible for changing Scenes and Quitting the Game
public class GameOver : MonoBehaviour
{
    
    // Method to Quit the Game
    public void Quit()
    {
        Application.Quit();
    }

    // Method to Restart the Game
    public void Restart()
    {
        SceneManager.LoadScene(2);
    }
    
    // Method to change to the Main Menu
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
