using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        //Debug.Log(horizontal);
        Vector2 position = transform.position;
        position.x += 0.05f * horizontal;
        position.y += 0.05f * vertical;
        transform.position = position; 

    }
}
