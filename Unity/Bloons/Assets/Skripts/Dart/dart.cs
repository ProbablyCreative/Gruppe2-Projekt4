using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dart : MonoBehaviour
{
    public int dartNum;
    public SpawnDarts spawnDarts;
    // Start is called before the first frame update
    void Start()
    {
        spawnDarts = GameObject.FindWithTag("SpawnManager").GetComponent<SpawnDarts>();
    }

    public void replace()
    {
        spawnDarts.replaceDart(dartNum);
    }
}
