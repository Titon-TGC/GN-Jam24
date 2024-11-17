using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; //Players max health
    public int currentHealth = 100; //Players current health

    public GameObject levelManager;
    private int healthAdd;
    private int newHealth;

    private LevelManager playerRespawn;
    private GameObject PlayerStats;
    private AudioSource audio;
    public AudioClip damage;
    public AudioClip death;
    public AudioClip heal;

    void Awake()
    {
        playerRespawn = FindFirstObjectByType<LevelManager>();
        audio = GetComponent<AudioSource>();

        PlayerStats = GameObject.Find("PlayerStats");
        healthAdd = PlayerStats.GetComponent<PlayerStats>().upgrade3Level;
        newHealth = maxHealth + healthAdd;
        maxHealth = newHealth;
    }

    void Start() //Runs once scene is active
    {
        currentHealth = maxHealth; //Sets players current health to the max health.
        levelManager = GameObject.Find("LevelManager");
        gameObject.SetActive(true);
    }

    public void TakeDamage(int amount) //Take Damage function to be called from other scripts.
    {
        currentHealth -= amount;
        audio.PlayOneShot(damage); //Current health - damage amount from other scripts.
        if(currentHealth <= 0) // If current health is less than or = 0
        {
            audio.PlayOneShot(death);
            levelManager.GetComponent<LevelManager>().Respawn();
            gameObject.SetActive(false);
        }
    }

    public void Heal(int amount) //Heal function to be called from other scripts.
    {
        currentHealth += amount; // Current health + heal amount from other scripts.
        audio.PlayOneShot(heal);
        if(currentHealth > maxHealth) // If current health is greater than max health.
        {
            currentHealth = maxHealth; //Set current health to max health.
        }
    }

    public void Revive()
    {
        currentHealth = maxHealth;
        gameObject.SetActive(true);
    }
}
