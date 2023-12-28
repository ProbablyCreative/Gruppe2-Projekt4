using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookInMovementDirection : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] public float speed = 0.5f;
    [SerializeField] public int tickRate = 60;
    [SerializeField] public bool aktivateRotation = false;
    [SerializeField] public float x;
    [SerializeField] public float y;
    [SerializeField] public float z;

    private Coroutine lookInMovement;

    private void Start()
    {
        startLookingAtMovement();
    }

    public void startLookingAtMovement()
    {
        if (lookInMovement != null)
        {
            StopCoroutine(lookInMovement);
        }

        lookInMovement = StartCoroutine(LookMovement());
    }

    private void Update()
    {
        x = rb.velocity.x;
        y = rb.velocity.y;
        z = rb.velocity.z;
    }

    private IEnumerator LookMovement()
    {
        Quaternion lookRotaion = Quaternion.LookRotation(rb.velocity).normalized;

        while (speed < 1) {
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotaion, speed);

            yield return null;
        }
    }

}
