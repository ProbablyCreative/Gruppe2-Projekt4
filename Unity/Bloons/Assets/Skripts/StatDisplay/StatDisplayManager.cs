using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatDisplayManager : MonoBehaviour
{
    [SerializeField] private List<StatDisplay> statDisplayList = new List<StatDisplay>();
    [SerializeField] private bool newHighscore = false;
    public void updateStats()
    {
        if (GameData.score > GameData.highScore)
        {
            GameData.highScore = GameData.score;
            newHighscore = true;
        }
        foreach (StatDisplay display in statDisplayList)
        {
            display.UpdateStats(newHighscore);
        }
    }

    public void Register(StatDisplay other)
    {
        statDisplayList.Add(other);
    }
}
