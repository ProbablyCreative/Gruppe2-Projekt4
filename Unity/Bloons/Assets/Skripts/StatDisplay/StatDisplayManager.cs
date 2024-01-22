using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatDisplayManager : MonoBehaviour
{
    [SerializeField] private List<StatDisplay> statDisplayList = new List<StatDisplay>();
    public void updateStats()
    {
        foreach (StatDisplay display in statDisplayList)
        {
            display.UpdateStats();
        }
    }

    public void Register(StatDisplay other)
    {
        statDisplayList.Add(other);
    }
}
