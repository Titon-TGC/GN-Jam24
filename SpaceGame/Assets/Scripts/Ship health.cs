using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shiphealth : MonoBehaviour
{
    public int maxHealth = 100; //Players max health
    public int currentHealth = 100; //Players current health

    private int healthAdd;
    private int newHealth;

    private GameObject levelManager;
    private GameObject PlayerStats;

    void Awake()
    {
        PlayerStats = GameObject.Find("PlayerStats");
        healthAdd = PlayerStats.GetComponent<PlayerStats>().upgrade4Level;
        newHealth = maxHealth + healthAdd;
        maxHealth = newHealth;
    }

    void Start() //Runs once scene is active
    {
        currentHealth = maxHealth; //Sets players current health to the max health.
    }

    public void ShipDamage(int amount) //Take Damage function to be called from other scripts.
    {
        currentHealth -= amount; //Current health - damage amount from other scripts.
        if(currentHealth <= 0) // If current health is less than or = 0
        {
            levelManager = GameObject.Find("LevelManager");
            levelManager.GetComponent<LevelManager>().lost = true;
            levelManager.GetComponent<LevelManager>().GameEnd();
        }
    }

}
