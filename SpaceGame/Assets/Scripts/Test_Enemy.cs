using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Enemy : MonoBehaviour
{
    public GameObject player;
    public GameObject ship;
    public float speed;
    private float distance;
    private float shipdistance;

    void Start()
    {
        
    }

    void Update()
    {
        UpdateDirection();
        SetVelocity();
    }

    private void UpdateDirection()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        shipdistance = Vector2.Distance(transform.position, ship.transform.position);

        if (distance < shipdistance)
        {
            Vector2 direction = player.transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        else
        {
            Vector2 shipdirection = ship.transform.position - transform.position;
            shipdirection.Normalize();
            float shipangle = Mathf.Atan2(shipdirection.y, shipdirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * shipangle);
        
        }
    }
    private void SetVelocity()
    {
        if (distance < shipdistance)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(this.transform.position, ship.transform.position, speed * Time.deltaTime);
        }
    }

        //distance = Vector2.Distance(transform.position, player.transform.position);
        //Vector2 direction = player.transform.position - transform.position;
        //direction.Normalize();
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //shipdistance = Vector2.Distance(transform.position, ship.transform.position);
        //Vector2 shipdirection = ship.transform.position - transform.position;
        //shipdirection.Normalize();
        //float shipangle = Mathf.Atan2(shipdirection.y, shipdirection.x) * Mathf.Rad2Deg;

        //transform.position = Vector2.MoveTowards(this.transform.position, ship.transform.position, speed * Time.deltaTime);
        //transform.rotation = Quaternion.Euler(Vector3.forward * shipangle);
        

        //if (distance < shipdistance)
        
            //transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        
}

