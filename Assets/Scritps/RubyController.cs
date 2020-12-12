﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        //Debug.Log(horizontal);
        Vector2 position = transform.position;
        position.x += 7.0f * horizontal * Time.deltaTime;
        position.y += 7.0f * vertical * Time.deltaTime;
        transform.position = position; 

    }
}
