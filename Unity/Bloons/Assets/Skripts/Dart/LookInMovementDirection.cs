using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookInMovementDirection : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] public float speed = 0.5f;
    [SerializeField] public int tickRate = 60;
    [SerializeField] public bool aktivateRotation = false;
    private Vector3 spawnPoint;
    private Quaternion spawnRotaion;
    private int count = 0;

    private void FixedUpdate()
    {
        if (count == 1){
            transform.rotation = Quaternion.LookRotation(rb.velocity).normalized;
        }
        else
        {
            count++;
        }
    }
        
    

}
