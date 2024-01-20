using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int levelNumber = 1;
    public GameObject balloonPrefab;
    public GameObject robotPrefab;
    private int balloonsRemaining;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBalloons());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBalloons()
    {
        int balloonCount = 0;
        switch (levelNumber)
        {
            case 1:
                balloonCount = 20;
                break;
            case 2:
                balloonCount = 40;
                break;
            case 3:
                balloonCount = 50;
                Instantiate(robotPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                break;
        }

        balloonsRemaining = balloonCount;

        for (int i = 0; i < balloonCount; i++)
        {
            Instantiate(balloonPrefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }

    public void OnBalloonDestroyed()
    {
        balloonsRemaining--;
        if (balloonsRemaining <= 0)
        {
            levelNumber++;
            if (levelNumber <= 3)
            {
                StartCoroutine(SpawnBalloons());
            }
        }
    }
}