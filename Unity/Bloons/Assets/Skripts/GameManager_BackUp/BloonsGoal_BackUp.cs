using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BloonsGoal_BackUp : MonoBehaviour
{
    public StatDisplayManager statDisplayManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bloon")
        {
            hitHP(other.gameObject.GetComponent<bloonSkript>().layer + 1);
            Destroy(other.gameObject);
        }
    }

    private void hitHP(int damage)
    {
        GameData.hp -= damage;
        GameData.hpU = damage;
        statDisplayManager.updateStats();
        if (GameData.hp <= 0)
        {
            endGame();
        }
    }

    private void endGame()
    {
        SceneManager.LoadScene(0);
    }
}
