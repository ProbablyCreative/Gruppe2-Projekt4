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
        UpdateStats();
    }

    public void UpdateStats()
    {
        textHP.text = "HP: " + GameData.hp;
        textScore.text = "Score: " + GameData.score;
        textMoney.text = "$: " + GameData.moneyy;
        textHPU.text = "- " + GameData.hpU;
        textScoreU.text = "+ " + GameData.scoreU;
        textMoneyU.text = "+ " + GameData.moneyyU;
    }
}
