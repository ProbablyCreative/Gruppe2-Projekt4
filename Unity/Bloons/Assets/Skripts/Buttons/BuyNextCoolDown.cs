using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyNextCoolDown : MonoBehaviour
{
    public TextMeshProUGUI cost;

    private void Start()
    {
        UpdateCost();
    }
    public void ActivateButton()
    {
        GameManager_BackUp gameManager = GameManager_BackUp.GlobalGameManager;
        if (!(gameManager.coolDownCost.Count > 0))
        {
            return;
        }
        if (GameData.moneyy >= gameManager.coolDownCost[0])
        {
            gameManager.updateMoney(-gameManager.coolDownCost[0]);
            gameManager.coolDownCost.RemoveAt(0);
            gameManager.fireCoolDown /= gameManager.fireCoolDownDiv;
            UpdateCost();
        }
    }

    public void UpdateCost()
    {
        GameManager_BackUp gameManager = GameManager_BackUp.GlobalGameManager;
        if (!(gameManager.coolDownCost.Count > 0))
        {
            cost.text = "MAX";
            return;
        }
        cost.text = "$" + gameManager.coolDownCost[0];
    }
}
