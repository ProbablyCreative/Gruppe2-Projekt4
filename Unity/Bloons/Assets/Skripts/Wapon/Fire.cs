using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject dartToFire;
    public float power = 1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fireDart()
    { Vector3 rotCorr = new Vector3(0, 180, 0);
        GameObject dart = Instantiate(dartToFire, transform.position, transform.rotation);
        dart.GetComponent<Rigidbody>().AddForce(transform.forward * power * 10, ForceMode.Impulse);
    }
}
