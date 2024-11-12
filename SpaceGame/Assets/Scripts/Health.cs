using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; //Players max health
    public int currentHealth = 100; //Players current health

    void Start() //Runs once scene is active
    {
        currentHealth = maxHealth; //Sets players current health to the max health.
    }

    public void TakeDamage(int amount) //Take Damage function to be called from other scripts.
    {
        currentHealth -= amount; //Current health - damage amount from other scripts.
        if(currentHealth <= 0) // If current health is less than or = 0
        {
            Debug.Log("You ded"); //Debug log for now
        }
    }

    public void Heal(int amount) //Heal function to be called from other scripts. (NOT TESTED IDK IF THIS WORKS)
    {
        currentHealth += amount; // Current health + heal amount from other scripts.
        if(currentHealth > maxHealth) // If current health is greater than max health.
        {
            currentHealth = maxHealth; //Set current health to max health.
        }
    }
}
