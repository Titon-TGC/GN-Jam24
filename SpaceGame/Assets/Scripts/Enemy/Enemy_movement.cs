using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public GameObject ship;
    public float speed;
    private float playerdistance;
    private float shipdistance;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        playerdistance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        shipdistance = Vector2.Distance(transform.position, ship.transform.position);
        Vector2 shipdirection = ship.transform.position - transform.position;
        shipdirection.Normalize();
        float shipangle = Mathf.Atan2(shipdirection.y, shipdirection.x) * Mathf.Rad2Deg;

        if (playerdistance <= shipdistance && player.activeSelf)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        else
        {
            transform.position = Vector2.MoveTowards(this.transform.position, ship.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * shipangle);
        }
    }
}