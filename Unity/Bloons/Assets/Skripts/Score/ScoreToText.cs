using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreToText : MonoBehaviour
{

    public Score score;
    public Text text;
    public bool renderHighscore = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (renderHighscore) {
            text.text = "Highscore: " + score.highScore;
        } else {
            text.text = "Score: " + score.score;
        }
    }
}
