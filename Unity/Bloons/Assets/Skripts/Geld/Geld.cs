using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geld : MonoBehaviour
{
    public int gold = 0;
    public int weaponUpgrade = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BuyWeaponUpgrade();
    }

    public void OnBalloonDestroyed()
    {
        gold += 5;
    }

    private void BuyWeaponUpgrade()
    {
        if (gold >= 200)
        {
            gold -= 200;
            weaponUpgrade++;
        }
    }
}
