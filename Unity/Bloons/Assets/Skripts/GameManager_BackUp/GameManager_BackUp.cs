using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_BackUp : MonoBehaviour
{
    public StatDisplayManager statDisplayManager;
    public int initHp = 100;
    // Start is called before the first frame update
    void Start()
    {
        GameData.hp = initHp;
        GameData.score = 0;
    }

    public void updateScore(int addScore)
    {
        GameData.score += addScore;
        statDisplayManager.updateStats();
    }
}
