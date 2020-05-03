using UnityEngine;
using UnityEngine.UI;

// Keeps track of the Current Score and the Highscore
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highScore;

    void Start()
    {
        // Calls the Highscore after every start to get the current Highscore Value
        highScore.text = PlayerPrefs.GetFloat("Highscore", 0).ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        // Keeps track of the player position in Z and uses this as Score Value
        float score = player.position.z;
        scoreText.text = score.ToString("0");
        
        // If the Score is higher the the Highscore, the Highscore changes to the new one
        if (score > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", score);
            highScore.text = score.ToString("0");
        }
    }
}
