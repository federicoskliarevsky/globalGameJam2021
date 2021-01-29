﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D player = new Rigidbody2D();
    Vector2 movement;
    private int collectedParts = 0;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        player.MovePosition(player.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void Winner()
    {
        if (this.collectedParts == 5)
        {
            // Scene.load("Winner");
        }
    }

    private void GameOver()
    {
        if (this.health <= 0)
        {
            // Scene.load("GameOver");
        }
    }
}
