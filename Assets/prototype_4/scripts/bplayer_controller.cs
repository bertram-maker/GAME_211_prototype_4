using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class bplayer_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D RB;
    private Vector2 vel;
    public bool onGround;
    public float speed;
    public float jumpForce;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vel = Vector2.zero;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            vel.x = -speed;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            vel.x = speed;
        }

        if (Keyboard.current.spaceKey.isPressed && onGround)
        {
            vel.y = jumpForce;
        }
        else
        {
            vel.y = RB.linearVelocity.y;
        }
        RB.linearVelocity = vel;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            onGround = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            onGround = false;
        }
    }
    
}
