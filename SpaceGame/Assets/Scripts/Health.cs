using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; //Players max health
    public int currentHealth = 100; //Players current health

<<<<<<< Updated upstream:SpaceGame/Assets/Scripts/Health.cs
    public GameObject levelManager;
=======
    private int healthAdd;
    private int newHealth;

    private LevelManager playerRespawn;
    private GameObject PlayerStats;

    void Awake()
    {
        playerRespawn = FindFirstObjectByType<LevelManager>();

        PlayerStats = GameObject.Find("PlayerStats");
        healthAdd = PlayerStats.GetComponent<PlayerStats>().upgrade3Level;
        newHealth = maxHealth + healthAdd;
        maxHealth = newHealth;
    }
>>>>>>> Stashed changes:SpaceGame/Assets/Scripts/Player Scripts/Health.cs

    void Start() //Runs once scene is active
    {
        currentHealth = maxHealth; //Sets players current health to the max health.
<<<<<<< Updated upstream:SpaceGame/Assets/Scripts/Health.cs
        levelManager = GameObject.Find("LevelManager");
=======
>>>>>>> Stashed changes:SpaceGame/Assets/Scripts/Player Scripts/Health.cs
    }

    public void TakeDamage(int amount) //Take Damage function to be called from other scripts.
    {
        currentHealth -= amount; //Current health - damage amount from other scripts.
        if(currentHealth <= 0) // If current health is less than or = 0
        {
            levelManager.GetComponent<LevelManager>().Respawn();
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
