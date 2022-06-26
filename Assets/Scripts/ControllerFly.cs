using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFly : MonoBehaviour
{
    public float JumpForce;
     Rigidbody2D rb;
    public Manager manager;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        if
            (Input.GetKey(KeyCode.Mouse0))
        {
           rb.velocity = Vector2.up * JumpForce;



        }
        
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        manager.GameOver();
    }
}
