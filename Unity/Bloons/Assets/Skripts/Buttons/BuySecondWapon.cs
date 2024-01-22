using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySecondWapon : MonoBehaviour
{
    public GameObject weapon;
    public GameObject weaponSpawn;
    public GameManager_BackUp gameManager;
    public int weaponCost = 400;
    private bool activated = false;
    public void activateButton()
    {
        if (!activated && GameData.moneyy >= weaponCost )
        {
            gameManager.updateMoney(-weaponCost);
            activated = true;
            Instantiate(weapon, weaponSpawn.transform.position, weaponSpawn.transform.rotation);
        }
        
    }
   
}
