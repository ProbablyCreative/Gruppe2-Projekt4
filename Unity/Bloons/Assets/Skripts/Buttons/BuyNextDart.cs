using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyNextDart : MonoBehaviour
{
    public TextMeshProUGUI cost;

    private void Start()
    {
        UpdatCost();
    }
    public void activateButton()
    {
        GameManager_BackUp gameManager = GameManager_BackUp.GlobalGameManager;
        if (!(gameManager.Darts.Count > 0 && gameManager.costDarts.Count > 0))
        {
            return;
        }
        if (gameManager.costDarts[0] < GameData.moneyy)
        {
            gameManager.updateMoney(-gameManager.costDarts[0]);
            gameManager.costDarts.RemoveAt(0);
            gameManager.currDart = gameManager.Darts[0];
            gameManager.Darts.RemoveAt(0);
            UpdatCost();
        }
    }

    public void UpdatCost()
    {
        GameManager_BackUp gameManager = GameManager_BackUp.GlobalGameManager;
        if (!(gameManager.Darts.Count > 0 && gameManager.costDarts.Count > 0))
        {
            cost.text = "MAX";
            return;
        }
        cost.text = "$" + gameManager.costDarts[0];
    }
}
