﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;

    public float changeTime = 3.0f;

    int direction = 1;
    float timer;

    Rigidbody2D rbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        timer = changeTime;

    }

    void Update() {

        timer -= Time.deltaTime;
        if (timer < 0) {
            direction *= -1;
            timer = changeTime;
        }        
    }
    
    void FixedUpdate()
    {
        Vector2 position = rbody.position;

        if (vertical) {
            position.y = position.y + Time.deltaTime * speed * direction;    
        } else {
            position.x = position.x + Time.deltaTime * speed * direction;
        }        
        
        rbody.MovePosition(position);
    }
}