using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.OpenXR.Features.Interactions;
public class Score : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;

    
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void AddScore(int points)
    {
        score += points;

        if (score > highScore)
        {
            highScore = score;

            // Speichern Sie den neuen Highscore in den PlayerPrefs
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
