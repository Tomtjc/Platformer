using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private float flapSpeed;
    DoNotDestroy death;
  

    void Start()
    {
        death = GameObject.FindGameObjectWithTag("GameMusic").GetComponent<DoNotDestroy>();
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Input.GetKey("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, flapSpeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" || collision.tag == "Object" || collision.tag == "Enemy")
        {
            
            Destroy(this.gameObject);
            death.Death();
        }
    }
}

