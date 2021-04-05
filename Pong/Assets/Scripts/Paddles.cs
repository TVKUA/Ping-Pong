using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    [SerializeField] private bool isPlayer1;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;

    public Joystick joystick;

    private float movement;

    void Update()
    {
        if (isPlayer1)
        {
            movement = joystick.Vertical;
        }
        else
        {
            movement = joystick.Vertical;
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
