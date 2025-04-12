using System;
using Unity.Mathematics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public float shiftSpeed = 8f;
    public int maxSaltos = 2;

    public float dashSpeed = 20f;
    public float dashDuracion = 0.2f;
    public float dashCooldown = 1f;
    public TrailRenderer trail;

    public float doubleTapTime = 0.3f;

    bool mirror = false;
    float horizontal;

    bool salto = false;
    bool Dash = false;
    bool puedeDash = true;
    bool haypiso = false;

    float lastShiftTime = -1f;

    int saltos = 0;

    Rigidbody2D rb;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = rb.GetComponent<Animator>();
        saltos = maxSaltos;
        if (trail != null) trail.emitting = false;
    }

    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
        voltear();

        if (Input.GetKeyDown(KeyCode.Space) && saltos > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            salto = true;
            saltos--;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (Time.time - lastShiftTime <= doubleTapTime && puedeDash)
            {
                StartCoroutine(Dasheo());
                lastShiftTime = -1f;
            }
            else
            {
                lastShiftTime = Time.time;
            }
        }
    }

    private void FixedUpdate()
    {
       if (!Dash)
       {      
        float total = speed;

        if (Input.GetKey(KeyCode.LeftShift) && haypiso)
        {
            total = shiftSpeed;
        }

        rb.linearVelocity = new Vector2(horizontal * total, rb.linearVelocity.y);
       }

    animator.SetFloat("velocidadX", Math.Abs(rb.linearVelocity.x));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            Vector2 normal = collision.contacts[0].normal;
            if (Vector2.Angle(normal, Vector2.up) < 30f)
            {
                salto = false;
                saltos = maxSaltos;
                haypiso = true;
            }
        
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            haypiso = false;
        }
    }

    void voltear()
    {
        if (horizontal > 0 && mirror == true || horizontal < 0 && mirror == false)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
            mirror = !mirror;
        }
    }

    System.Collections.IEnumerator Dasheo()
    {
        puedeDash = false;
        Dash = true;

        if (trail != null) trail.emitting = true;

        float dashDirection = mirror ? -1 : 1;
        rb.linearVelocity = new Vector2(dashDirection * dashSpeed, 0f);

        yield return new WaitForSeconds(dashDuracion);

        Dash = false;
        if (trail != null) trail.emitting = false;

        yield return new WaitForSeconds(dashCooldown);
        puedeDash = true;
    }

 
}
