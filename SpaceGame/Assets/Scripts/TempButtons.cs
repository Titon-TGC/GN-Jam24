using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempButtons : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Damage()
    {
        Debug.Log("Player hit!");
        Player.GetComponent<Shiphealth>().ShipDamage(10);
    }

    public void Heal()
    {
        Debug.Log("Player healed!");
        Player.GetComponent<Health>().Heal(10);
    }
}
