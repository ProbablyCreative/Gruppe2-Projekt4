using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyNextDart : MonoBehaviour
{
    
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
        }
    }
}
