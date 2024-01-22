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
    public int weaponCost = 400;
    private bool activated = false;

    private void Start()
    {
        updateCost();
    }
    public void activateButton()
    {
        if (!activated && GameData.moneyy >= weaponCost )
        {
            gameManager.updateMoney(-weaponCost);
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
        cost.text = "$" + weaponCost;
    }
}
