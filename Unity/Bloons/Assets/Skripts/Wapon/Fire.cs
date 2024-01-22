using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float power = 1;
    private float currCoolDown;
    // Start is called before the first frame update
    private void Start()
    {
        currCoolDown = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (currCoolDown > 0) {
            currCoolDown -= Time.deltaTime;
        }
    }

    public void fireDart()
    { 
        if (currCoolDown <= 0)
        {
            GameObject dart = Instantiate(GameManager_BackUp.GlobalGameManager.currDart, transform.position, transform.rotation);
            dart.GetComponent<Rigidbody>().AddForce(transform.forward * power * 10, ForceMode.Impulse);
            currCoolDown = GameManager_BackUp.GlobalGameManager.fireCoolDown;
        }
        
    }
}
