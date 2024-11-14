using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerawareness : MonoBehaviour
{
    public Transform Player;
    public Transform Ship;
    public float MoveSpeed = 4;

    void Start()
    {

    }

    void Update()
    {

        if (Vector2.Distance(transform.position, Player.position) <= Vector2.Distance(transform.position, Ship.position))
        {
            transform.LookAt(Player);
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
        else
        {
            transform.LookAt(Ship);
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
    }
}