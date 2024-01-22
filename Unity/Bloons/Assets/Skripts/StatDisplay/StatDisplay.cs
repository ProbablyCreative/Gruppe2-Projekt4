using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatDisplay : MonoBehaviour
{
    public StatDisplayManager Manager;

    private void Start()
    {
        Manager.Register(this);
    }

    public void UpdateStats()
    {

    }
}
