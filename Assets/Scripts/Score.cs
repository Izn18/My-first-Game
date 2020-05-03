using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highScore;

    void Start()
    {
        highScore.text = "Test";
        highScore.text = PlayerPrefs.GetFloat("Highscore", 0).ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        float score = player.position.z;
        scoreText.text = score.ToString("0");
        
        if (score > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", score);
            highScore.text = score.ToString("0");
        }
    }
}
