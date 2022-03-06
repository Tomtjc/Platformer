using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    //[SerializeField] bool isGrounded = false;
    //[SerializeField] Transform groundCheckCollider;
    //[SerializeField] LayerMask groundLayer;
    private Vector2 playerDirection;
    [SerializeField] private Camera mainCamera;
    //[SerializeField] private float colliderRadius = 0.2f;
    [SerializeField] private int gravityOn = 1;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    

    private void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if (Input.GetKeyDown("space") && gravityOn == 1)
        {
            rb.gravityScale = -1;
            gravityOn = 0;

        }
        else if(Input.GetKeyDown("space") && gravityOn == 0)
        {
            rb.gravityScale = 1;
            gravityOn = 1;
        }

        

    }
   

}
