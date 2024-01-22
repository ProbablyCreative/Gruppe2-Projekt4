using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BloonsGoal_BackUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bloon")
        {
            Debug.Log("Test");
            hitHP(other.gameObject.GetComponent<bloonSkript>().layer + 1);
            Destroy(other.gameObject);
        }
    }

    private void hitHP(int damage)
    {
        GameData.hp -= damage;
        Debug.Log("HP Update:");
        Debug.Log(GameData.hp);
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
