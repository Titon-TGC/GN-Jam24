using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; //Players max health
    public int currentHealth = 100; //Players current health

    private LevelManager playerRespawn;

    void Start() //Runs once scene is active
    {
        currentHealth = maxHealth; //Sets players current health to the max health.
    }

    private void Awake()
    {
        playerRespawn = FindFirstObjectByType<LevelManager>();
    }

    public void TakeDamage(int amount) //Take Damage function to be called from other scripts.
    {
        currentHealth -= amount; //Current health - damage amount from other scripts.
        if(currentHealth <= 0) // If current health is less than or = 0
        {
            playerRespawn.Respawn();
            Destroy(gameObject);
        }
    }

    public void Heal(int amount) //Heal function to be called from other scripts.
    {
        currentHealth += amount; // Current health + heal amount from other scripts.
        if(currentHealth > maxHealth) // If current health is greater than max health.
        {
            currentHealth = maxHealth; //Set current health to max health.
        }
    }
}
