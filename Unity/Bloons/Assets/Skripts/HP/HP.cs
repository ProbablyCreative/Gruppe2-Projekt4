using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HP : MonoBehaviour
{
    public int hp = 100; 
    public Text hpText; 

    
    void Start()
    {
        
        hpText.text = "HP: " + hp;
    }

    
    void Update()
    {
        hpText.text = "HP: " + hp;
    }

    public void ChangeHP(int amount)
    {
        hp += amount;
        // Ensure HP doesn't go below 0
        if (hp < 0) hp = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bloon")
        {
            int damage = collision.gameObject.GetComponent<bloonSkript>().layer;

            ChangeHP(-damage);
        }
    }

  /*     void Update()
    {
        hpText.text = "HP: " + hp;

        if (hp <= 0)
        {
            Debug.Log("Spiel beendet");
            Application.Quit();
        }
    }

    void KameraUI()
    {
        // Erstellen Sie ein neues GameObject für das Canvas
        GameObject canvasObject = new GameObject("Canvas");

        // Fügen Sie das Canvas-Element hinzu
        Canvas canvas = canvasObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.WorldSpace;

        // Fügen Sie das Canvas der Kamera hinzu
        canvasObject.transform.SetParent(Camera.main.transform);

        // Positionieren Sie das Canvas vor der Kamera
        canvasObject.transform.localPosition = new Vector3(0, 0, 1);

        // Initialisieren Sie die HP-Anzeige
        hpText.text = "HP: " + hp;
    }*/
}