using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{
    public bool broken = true;
    public float speed = 3.0f;
    public bool vertical;

    public float changeTime = 3.0f;
    public ParticleSystem smokeEffect;

    int direction = 1;
    float timer;

    Rigidbody2D rbody;
    Animator animator;

    public void Fix()
    {
        broken = false;
        rbody.simulated = false;
        animator.SetTrigger("Fixed");
        smokeEffect.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
    }
    
    void OnCollisionEnter2D(Collision2D other) 
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

    void Update()
    {
        if (!broken)
        {
            return;
        }

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction *= -1;
            timer = changeTime;
        }
    }

    void FixedUpdate()
    {
        if (!broken)
        {
            return;
        }

        Vector2 position = rbody.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0);
        }

        rbody.MovePosition(position);
    }
}
