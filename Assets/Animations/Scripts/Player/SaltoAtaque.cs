using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoAtaque: MonoBehaviour
{
    public float bounce;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, bounce);
            Destroy(other.gameObject);

    
        }
    }
}