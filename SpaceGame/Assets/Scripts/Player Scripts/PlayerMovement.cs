using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float movespeed = 5f;

    private float speedAdd;
    private float newSpeed;
    
    Vector2 Player_move;
    Vector2 Mouse_point;

    private GameObject PlayerStats;

    void Awake()
    {
        PlayerStats = GameObject.Find("PlayerStats");
        speedAdd = PlayerStats.GetComponent<PlayerStats>().upgrade2Level;
        newSpeed = movespeed + speedAdd;
        movespeed = newSpeed;
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Player_move = new Vector2(moveX, moveY).normalized;
        Mouse_point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(Player_move.x * movespeed, Player_move.y * movespeed);

        Vector2 aim = Mouse_point - body.position;
        float aimangle = Mathf.Atan2(aim.y,aim.x) * Mathf.Rad2Deg - 90f;
        body.rotation = aimangle;

        ScreenBounds();
    }

    private void ScreenBounds()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        if ((screenPosition.x < 0 && body.velocity.x < 0) || (screenPosition.x > Camera.main.pixelWidth && body.velocity.x > 0))
        {
            body.velocity = new Vector2(0, body.velocity.y);
        }

        if ((screenPosition.y < 0 && body.velocity.y < 0) || (screenPosition.y > Camera.main.pixelHeight && body.velocity.y > 0))
        {
            body.velocity = new Vector2(body.velocity.x, 0);
        }
    }
}

