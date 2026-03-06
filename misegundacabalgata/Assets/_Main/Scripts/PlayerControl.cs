using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;
    [SerializeField] private float fuerzaSalto = 125f;
    [SerializeField] private bool isGround;
    [SerializeField] private float moveSpeed = 5f;
    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // || &&
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGround)
        {
            _rb2d.AddForce(Vector2.up * fuerzaSalto);
        }

        float moveInput = Input.GetAxis("Horizontal");
        _rb2d.linearVelocity = new Vector2(moveInput * moveSpeed, _rb2d.linearVelocity.y);

       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround=true;
        }
        
    }
    private void OnCollisionExit2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            isGround = false;
        }

    }
}
