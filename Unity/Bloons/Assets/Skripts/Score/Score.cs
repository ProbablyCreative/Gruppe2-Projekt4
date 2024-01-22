using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Laden Sie den Highscore aus den PlayerPrefs
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int points)
    {
        score += points;

        // Überprüfen Sie, ob der neue Score höher ist als der Highscore
        if (score > highScore)
        {
            highScore = score;

            // Speichern Sie den neuen Highscore in den PlayerPrefs
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
