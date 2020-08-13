using System;
using System.Collections;
using System.Security.Cryptography;
using UnityEngine;

public class Walk : MonoBehaviour
{

    public float walkSpeed;
    bool left;
    public LayerMask Ground;
    public GameObject Walls;
    public Rigidbody2D rb;
    bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector2.down, 1f, Ground);
        if (left == false && isGrounded == true)
        {
          
            rb.AddForce(Vector2.right * walkSpeed, ForceMode2D.Impulse);
            
        }
        else
        {
            if (isGrounded == true)
            {
                rb.AddForce(Vector2.right * -walkSpeed, ForceMode2D.Impulse);
            }
            
        }
        
       
    }
        void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
            left = !left;
        GetComponent<SpriteRenderer>().flipX = left;
    }
    

    
}
