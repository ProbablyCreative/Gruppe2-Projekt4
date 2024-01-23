using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.OpenXR.Features.Interactions;

public class burg : MonoBehaviour
{
    private int _hp;
    private int hp
    {
        get { return _hp; }
        set {
            _hp = Math.Max(0, value);
        }
    }
    public Text hpText; 
    public GameObject Bloon; 

    public Score score;  /// später löschen 

    void Start()
    {
        
        hp = 100;
        //  hpText.text = "HP: " + hp;
    }

    void Update()
    {
        hpText.text = "HP: " + hp;

        if (hp <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Kollision erkannt mit " + collision.gameObject.name);
        if (collision.gameObject.tag == "Bloon")
        {
            // Use the reference to the Bloon GameObject here
            int damage = Bloon.GetComponent<bloonSkript>().layer; 
            Debug.Log("Schaden genommen: " + damage);
            hp -= damage;

            score.AddScore(1);  ////später löschen

        }
    }
}