using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class HitEnvironment : MonoBehaviour
{
    private Rigidbody rb;
    private LookInMovementDirection look;
    // private float countDown = 10f;
    //private bool startDestoying = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        look = GetComponent<LookInMovementDirection>();
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Environment")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            look.aktivateRotation = false;
            startDestoying = true;
            GetComponent<BoxCollider>().enabled = false;
        }

    }*/

    private void FixedUpdate()
    {
        if (gameObject.transform.position.y < -15)
        {
            Destroy(gameObject);
        }
        
    }
}
