﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{

    public float speed = 7.0f;
    float horizontal;
    float vertical;

    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;   
        rigidbody2d = GetComponent<Rigidbody2D>();  

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //Debug.Log(horizontal);

    }

    void FixedUpdate() 
    {
        Vector2 position = transform.position;
        position.x += speed * horizontal * Time.deltaTime;
        position.y += speed * vertical * Time.deltaTime;
        transform.position = position;

        rigidbody2d.MovePosition(position);

    }
}
