using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float movespeed = 5f;
    
    Vector2 Player_move;
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Player_move = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(Player_move.x * movespeed, Player_move.y * movespeed);
    }
}

