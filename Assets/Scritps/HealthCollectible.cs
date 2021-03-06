﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public ParticleSystem pickupHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        RubyController controller = other.GetComponent<RubyController>();                

        if (controller != null) {
            if (controller.currentHealth < controller.maxHealth) {
                Vector2 pos = transform.position;
                Instantiate(pickupHealth, pos, Quaternion.identity);
                controller.ChangeHealth(1);
                Destroy(gameObject);
            } else {
            Debug.Log("Ruby health is full!");
            }
        }        
    }
}
