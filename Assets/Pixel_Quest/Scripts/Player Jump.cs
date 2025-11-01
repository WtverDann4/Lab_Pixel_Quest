using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Playerjump : MonoBehaviour
{     //Components
    private Rigidbody2D rb;
    //forces
    public float jumpForce = 10;
    public float fallForce = 2;
    private Vector2 _gravityVector;
    //Capsule
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;
    //Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    //Water check
    public bool _waterCheck;
    private string _waterTag = "Water";

    // Start is called before the first frame update
    void Start()
    {
        _gravityVector = new Vector2(0, Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



        //Checks if player is touching ground
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position,
        new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal,
       0, groundMask);
        // Checks if the player is trying to jump/can jump
        if (Input.GetKeyDown(KeyCode.Space) && (_groundCheck || _waterCheck))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        }
        //chcks if the gravity should be getting faster
        if (rb.velocity.y < 0 && !_waterCheck)
        {
            rb.velocity += _gravityVector * (fallForce * Time.deltaTime);

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag)) { _waterCheck = true; }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag)) { _waterCheck = false; }


    }
}