using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class HitEnvironment : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Environment")
        {
            
            Destroy(gameObject);
        }
    }
}
