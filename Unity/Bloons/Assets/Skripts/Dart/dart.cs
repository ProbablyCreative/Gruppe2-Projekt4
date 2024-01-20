using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dart : MonoBehaviour
{
    public int durability = 1;
    public int power = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bloon")
        {
            bloonSkript otherD = other.gameObject.GetComponent<bloonSkript>();
            otherD.hitThisBloon(power);
            durability -= 1;
            if (durability <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
