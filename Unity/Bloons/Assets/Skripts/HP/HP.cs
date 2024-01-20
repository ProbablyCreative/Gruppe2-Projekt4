using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import the UI library

public class HP : MonoBehaviour
{
    public int hp = 100; // The player's health points
    public Text hpText; // The UI Text component that will display the HP

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the HP display
        hpText.text = "HP: " + hp;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the HP display
        hpText.text = "HP: " + hp;
    }

    // Method to change the HP value
    public void ChangeHP(int amount)
    {
        hp += amount;
        // Ensure HP doesn't go below 0
        if (hp < 0) hp = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object we collided with has a tag "Balloon"
        if (collision.gameObject.tag == "Bloon")
        {
            // Calculate damage based on the balloon's layer
            int damage = collision.gameObject.layer * 2;

            // Decrease the player's HP by the calculated damage
            ChangeHP(-damage);
        }
    }
}