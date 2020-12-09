﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
          movement = Input.GetAxisRaw("VerticalP1");
        }
        else
        {
          movement = Input.GetAxisRaw("VerticalP2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
