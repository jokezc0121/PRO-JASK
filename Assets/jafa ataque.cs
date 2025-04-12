using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jafaataque : MonoBehaviour
{
    float horizontal;
    private Rigidbody2D rigiBody;
    
    public float speed;
    public float jumpForce;
    
    
    void Start()
    {
        rigiBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = 10;
        rigiBody.linearVelocity = new Vector2(horizontal * speed, rigiBody.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            rigiBody.linearVelocity = new Vector2(rigiBody.linearVelocity.x, jumpForce);
            
        }
    }

    private void FixedUpdate()
    {
        rigiBody.linearVelocity = new Vector2(horizontal, rigiBody.linearVelocity.y);
    }
    
}
