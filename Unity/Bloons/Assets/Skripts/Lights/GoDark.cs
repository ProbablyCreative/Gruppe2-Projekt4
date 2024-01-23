using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDark : MonoBehaviour
{
    public int value = 100;
    void Update()
    {
        if (GameData.score > value)
        {
            gameObject.SetActive(false);
        }
    }
}
