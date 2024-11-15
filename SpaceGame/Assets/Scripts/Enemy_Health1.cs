using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy_Health1 : MonoBehaviour
{
    public int maxHealth = 100; //Enemy max health
    public int currentHealth = 100; //Enemy current health
    public UnityEvent OnDied;

    void Awake() //Runs once object is active
    {
        currentHealth = maxHealth; //Sets Enemy current health to the max health.
    }

    public void DeltDamage(int amount) //Delt Damage function to be called from other scripts.
    {
        currentHealth -= amount; //Current health - damage amount from other scripts.
        if(currentHealth <= 0) // If current health is less than or = 0
        {
            OnDied.Invoke();
            Destroy(gameObject);
        }
    }
}
