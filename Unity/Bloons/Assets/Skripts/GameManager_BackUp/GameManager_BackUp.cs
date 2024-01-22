using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_BackUp : MonoBehaviour
{
    public StatDisplayManager statDisplayManager;
    public int initHp = 100;
    public static System.Random rnd = new System.Random();
    // Start is called before the first frame update

    private void Awake()
    {
        GameData.hp = initHp;
        GameData.score = 0;
        GameData.moneyy = 0;
        GameData.hpU = 0;
        GameData.scoreU = 0;
        GameData.moneyyU = 0;
    }

    public void updateScore(int addScore, int money)
    {
        GameData.moneyy += money;
        GameData.moneyyU = money;
        GameData.score += addScore;
        GameData.scoreU = addScore;
        statDisplayManager.updateStats();
    }
}
