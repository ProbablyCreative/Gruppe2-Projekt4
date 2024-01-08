using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMovement : MonoBehaviour
{
    private Rigidbody rb;
    public SpawnDarts spawner;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void unlock()
    {
        rb.constraints = RigidbodyConstraints.None;
        spawner.spawnNew();
    }
}
