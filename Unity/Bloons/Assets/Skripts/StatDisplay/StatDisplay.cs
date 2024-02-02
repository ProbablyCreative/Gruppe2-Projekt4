using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatDisplay : MonoBehaviour
{
    public StatDisplayManager Manager;
    public TextMeshProUGUI textHP;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textMoney;
    public TextMeshProUGUI textHPU;
    public TextMeshProUGUI textScoreU;
    public TextMeshProUGUI textMoneyU;

    private void Start()
    {
        Manager.Register(this);
        UpdateStats(false);
    }

    public void UpdateStats(bool newHighScore)
    {
        textHP.text = "HP: " + GameData.hp;
        textHPU.text = "- " + GameData.hpU;
        textScore.text = "Score: " + GameData.score;
        if (newHighScore)
        {
            textScore.color = Color.yellow;
        }
        textScoreU.text = "+ " + GameData.scoreU;

        textMoney.text = "$: " + GameData.moneyy;
        if (GameData.moneyyU >= 0)
        {
            textMoneyU.text = "+ " + GameData.moneyyU;
            textMoneyU.color = Color.green;
        }
        else
        {
            textMoneyU.text = "- " + -GameData.moneyyU;
            textMoneyU.color = Color.red;
        }
        
        
    }
}
