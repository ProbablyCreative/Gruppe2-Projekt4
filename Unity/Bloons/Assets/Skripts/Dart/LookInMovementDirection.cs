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

    private Coroutine lookInMovement;

    private void Start()
    {
       
    }

    public void startLookingAtMovement()
    {
        if (lookInMovement != null)
        {
            StopCoroutine(lookInMovement);
        }

        lookInMovement = StartCoroutine(LookMovement());
    }

    public void stopRotation()
    {
        if (lookInMovement != null)
        {
            StopCoroutine (lookInMovement);
        }
    }

    private void Update()
    {

    }

    private IEnumerator LookMovement()
    {
        while (speed < 1) {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(rb.velocity).normalized, speed);

            yield return null;
        }
    }

}
