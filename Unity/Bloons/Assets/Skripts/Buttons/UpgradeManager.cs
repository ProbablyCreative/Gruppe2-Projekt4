using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    private List<BuyNextDart> Dart = new List<BuyNextDart>();
    private List<BuyNextCoolDown> coolDown = new List<BuyNextCoolDown>();
    private List<BuySecondWapon> Weapon = new List<BuySecondWapon>();

    public void registerDart(BuyNextDart dart)
    {
        Dart.Add(dart);
    }

    public void registerCoolDown(BuyNextCoolDown cooldown)
    {
        coolDown.Add(cooldown);
    }

    public void registerWeapon(BuySecondWapon wapon)
    {
        Weapon.Add(wapon);
    }

    public void UpdateBuyStuff()
    {
        foreach (var dart in Dart)
        {
            dart.UpdatCost();
        }
        foreach (var w in Weapon)
        {
            w.updateCost();
        }
        foreach(var c in coolDown)
        {
            c.UpdateCost();
        }
    }
}
