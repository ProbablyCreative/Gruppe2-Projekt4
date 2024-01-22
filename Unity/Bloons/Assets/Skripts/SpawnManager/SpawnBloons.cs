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
    public GameManager_BackUp gameManager;

    //Difficulty Increas

    // The Score it needs to upgrade the first time
    public int scoreThreshhold = 100;
    //The Multiplyer of the ScoreThreshold it needs to upgrade every time after the first time
    public float scoreMultiplier = 2;
    //Times the Amount the spawnrate gets increased
    public float spawnRateMulti = 1;
    //Amount of Layer added to new Bloons
    public int layerUpdatePlus = 0;
    //The first Bloons start with this Layer
    public int startLayer = 0;

    private int maxLayer;
    private int currLayer;
    private int timesUpped = 0;
    private float usedScore = 0;


    private float time = 0;

    private void Start()
    {
        maxLayer = spawnManager.bloonsM.Length - 1;
        currLayer = startLayer;
    }


    void Update()
    {
        if (!(startDelay < 0))
        {
            startDelay -= Time.deltaTime;
            return;
        }
        time += Time.deltaTime;
        if (delay < time)
        {
            time -= delay;
            spawnBloonNow();
        }
        
    }

    private void spawnBloonNow ()
    {
        checkForeDiff();
        GameObject temp = Instantiate(bloons, transform.position, transform.rotation);
        bloonSkript temp2 = temp.GetComponent<bloonSkript>();
        temp2.spawnManager = spawnManager;
        temp2.gameManager = gameManager;
        temp2.layer = currLayer;
        temp.GetComponent<FollowThePath>().path = path;
    }

    private void checkForeDiff()
    {
        float diff;
        if (timesUpped == 0)
        {
            diff = GameData.score - usedScore - scoreThreshhold;
        }
        else
        {
            diff = GameData.score - usedScore - (scoreThreshhold * scoreMultiplier * timesUpped);
        }
        if (diff > 0)
        {
            nextStep();
            if (timesUpped == 0)
            {
                usedScore += scoreThreshhold;
            }
            else
            {
                usedScore += scoreThreshhold * scoreMultiplier * timesUpped;
            }
           
            timesUpped++;
        }
    }

    private void nextStep()
    {
        if (currLayer < maxLayer)
        {
            currLayer += layerUpdatePlus;
        }
        delay /= spawnRateMulti;
    }
}
