using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class HitEnvironment : MonoBehaviour
{
    private Rigidbody rb;
    private LookInMovementDirection look;
    private float countDown = 10f;
    private bool startDestoying = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        look = GetComponent<LookInMovementDirection>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Environment")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            look.aktivateRotation = false;
            startDestoying = true;
        }

    }

    private void FixedUpdate()
    {
        if (countDown < 0)
        {
            Destroy(gameObject);
        }
        if (startDestoying)
        {
            countDown -= Time.fixedDeltaTime;
        }
        
    }
}
