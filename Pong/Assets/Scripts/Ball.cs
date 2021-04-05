using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        Movement();
    }

    void Update()
    {
        
    }

    private void Movement()
    {
        float x = Random.Range(0, 2) == 0 ? 1 : -1;
        float y = Random.Range(0, 2) == 0 ? 1 : -1 ;

        rb.velocity = new Vector2(speed * x, speed * y);

    }
}
