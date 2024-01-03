using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public PathHolder path;
    public float speed = 5;
    private int currentCheckPoint;

    private void Update()
    {
        followPathFunc();
    }

    private void followPathFunc()
    {
        if (currentCheckPoint >= path.points.Length)
        {
            return;
        }
        Vector3 target = Vector3.MoveTowards(transform.position, path.points[currentCheckPoint].transform.position, speed * Time.deltaTime);
        if (target == transform.position)
        {
            currentCheckPoint += 1;
        }
        transform.position = target;
    }
}
