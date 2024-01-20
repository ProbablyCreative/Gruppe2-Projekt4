using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBloons : MonoBehaviour
{
    public GameObject bloons;
    public float delay;
    public float startDelay;
    public PathHolder path;
    public SpawnManager spawnManager;
    private float time = 0;
    



    void Update()
    {
        time += Time.deltaTime;
        if (!(startDelay < 0))
        {
            startDelay -= Time.deltaTime;
            return;
        }
        if (delay < time)
        {
            time -= delay;
            GameObject temp =  Instantiate(bloons, transform.position, transform.rotation);
            temp.GetComponent<bloonSkript>().spawnManager = spawnManager;
            temp.GetComponent<FollowThePath>().path = path;
        }
        
    }
}
