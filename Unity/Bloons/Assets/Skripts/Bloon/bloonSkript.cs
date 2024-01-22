using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class bloonSkript : MonoBehaviour
{
    [SerializeField] public int layer;
    private Material[] layerList;
    public SpawnManager spawnManager;
    public MeshRenderer visual;
    public GameManager_BackUp gameManager;

    
    private void Start()
    {
        layerList = spawnManager.bloonsM;
        updateLayer();
    }

    public void hitThisBloon (int value)
    {
        if (layer + 1 > value)
        {
            gameManager.updateScore(value, GameManager_BackUp.rnd.Next(0, (value + 1) * 2));
        }
        else
        {
            gameManager.updateScore(layer + 1, GameManager_BackUp.rnd.Next(0, (layer + 2) * 2));
        }
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
