using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class bloonSkript : MonoBehaviour
{
    [SerializeField] private int layer;
    public static GameObject[] layerList;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dart")
        {
            dart otherD = other.GetComponent<dart>();
            hitThisBloon(otherD.power);
            otherD.durability--;
            if (otherD.durability <= 0)
            {
                Destroy(other.gameObject);
            }
        }
    }

    private void hitThisBloon (int value)
    {
        layer -= value;
        if (layer < 0)
        {
            Destroy(gameObject);
        }
        GameObject child = gameObject.GetNamedChild("Visual");
        Destroy(child.transform.GetChild(0).gameObject);
        Instantiate(layerList[layer], layerList[layer].transform.position, layerList[layer].transform.rotation, child.transform);
    }
}
