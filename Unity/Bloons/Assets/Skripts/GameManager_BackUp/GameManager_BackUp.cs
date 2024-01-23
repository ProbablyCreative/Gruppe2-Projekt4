using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class GameManager_BackUp : MonoBehaviour
{
    public StatDisplayManager statDisplayManager;
    public int initHp = 100;
    public GameObject currDart;
    public List<GameObject> Darts;
    public List<int> costDarts;
    public float fireCoolDownDiv = 1.5f;
    public List<int> coolDownCost;
    public float fireCoolDown = 0.5f;
    public static System.Random rnd = new System.Random();
    public static GameManager_BackUp GlobalGameManager;
    public int woeaponCost = 500;
    // Start is called before the first frame update

    private void Awake()
    {
        GlobalGameManager = this;
        GameData.hp = initHp;
        GameData.score = 0;
        GameData.moneyy = 0;
        GameData.hpU = 0;
        GameData.scoreU = 0;
        GameData.moneyyU = 0;
    }

    //Updates Score and Money, don't ask why (to lazy to change)
    public void updateScore(int addScore, int money)
    {
        GameData.moneyy += money;
        GameData.moneyyU = money;
        GameData.score += addScore;
        GameData.scoreU = addScore;
        statDisplayManager.updateStats();
    }


    public void updateMoney(int money)
    {
        GameData.moneyy += money;
        GameData.moneyyU = money;
        statDisplayManager.updateStats();
    }
}
