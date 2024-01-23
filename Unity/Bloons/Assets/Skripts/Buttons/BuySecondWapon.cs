using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuySecondWapon : MonoBehaviour
{
    public GameObject weapon;
    public GameObject weaponSpawn;
    public GameManager_BackUp gameManager;
    public TextMeshProUGUI cost;
    private static bool activated = false;

    private void Start()
    {
        gameManager = GameManager_BackUp.GlobalGameManager;
        updateCost();
    }
    public void activateButton()
    {
        updateCost();
        if (!activated && GameData.moneyy >= gameManager.woeaponCost)
        {
            gameManager.updateMoney(-gameManager.woeaponCost);
            activated = true;
            updateCost();
            Instantiate(weapon, weaponSpawn.transform.position, weaponSpawn.transform.rotation);
        }
        
    }
   
    public void updateCost()
    {
        if (activated)
        {
            cost.text = "MAX";
            return;
        }
        cost.text = "$" + gameManager.woeaponCost;
    }
}
