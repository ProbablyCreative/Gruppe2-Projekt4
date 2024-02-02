using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

public class MenuScore : MonoBehaviour
{
    public TextMeshProUGUI HighScore;
    public TextMeshProUGUI LastScore;

    private void Start()
    {
        HighScore.text = "" + GameData.highScore;
        LastScore.text = "" + GameData.score;
    }
}
