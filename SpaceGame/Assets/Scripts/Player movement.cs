using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float movespeed = 5f;
    
    Vector2 Player_move;
    Vector2 Mouse_point;
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
    }
}

