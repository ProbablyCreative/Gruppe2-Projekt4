using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDarts : MonoBehaviour
{
    [SerializeField] public GameObject dart;
    private GameObject current;

    private void Start()
    {
        current = Instantiate(dart, transform.position, transform.rotation);
        current.GetComponent<activateMovement>().spawner = this;
    }

    public void spawnNew() {
        current = Instantiate(dart, transform.position, transform.rotation);
        current.GetComponent<activateMovement>().spawner = this;
    }

}
