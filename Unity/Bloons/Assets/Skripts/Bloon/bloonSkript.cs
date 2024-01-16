using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class bloonSkript : MonoBehaviour
{
    [SerializeField] private int layer;
    private Material[] layerList;
    public SpawnManager spawnManager;
    public MeshRenderer visual;

    
    private void Start()
    {
        layerList = spawnManager.bloonsM;
        updateLayer();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Trigger Happend");
        if (other.gameObject.tag == "Dart")
        {
            dart otherD = other.gameObject.GetComponent<dart>();
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
            return;
        }
        updateLayer();
    }

    private void updateLayer()
    {
        List<Material> temp = new List<Material>();
        temp.Add(layerList[layer]);
        visual.SetMaterials(temp);
    }

   
}
