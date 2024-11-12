using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempButtons : MonoBehaviour
{
    public GameObject Player;

    public void Damage()
    {
        Debug.Log("Player hit!");
        Player.GetComponent<Health>().TakeDamage(10);
    }

    public void Heal()
    {
        Debug.Log("Player healed!");
        Player.GetComponent<Health>().Heal(10);
    }
}
