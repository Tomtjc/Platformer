using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pogo : MonoBehaviour
{

    private Rigidbody2D rb;
    //DoNotDestroy death;
    [SerializeField] float turnSpeed = 20f;
    [SerializeField] bool isGrounded = false;
    [SerializeField] bool isGrounded2 = false;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] Transform groundCheckCollider2;
    [SerializeField] private float colliderRadius = 0.2f;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] int bounce = 2;
    [SerializeField] int boost = 2;
    //[SerializeField] float rotation = 0;
    public float timeBetweenBounce = 0.10f;
    private float bounceTime;
    int x = 0;
    int y = 0;
    float horizontalInput = 0;
   

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        

    }

    
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        

        transform.Rotate(Vector3.back * horizontalInput * turnSpeed * Time.deltaTime);
        

        isGrounded = false;
        isGrounded2 = false;
        GroundCheck();
        GroundCheck2();

        //rotation = Mathf.Abs(transform.rotation.z);

        if (isGrounded == false)
        {
            x = 0;
        }

        if (isGrounded2 == false)
        {
            y = 0;
        }

        if (isGrounded == true && x == 0)
        {
            if (Time.time > bounceTime)
            {
                rb.velocity = new Vector2(0, bounce);
                rb.AddForce(-transform.up * boost);
                Debug.Log("IsGroundedOmhoog");
                x = 1;
            }
        }

        if (isGrounded2 == true && y == 0)
        {
            if (Time.time > bounceTime)
            {
                rb.velocity = new Vector2(0, bounce);
                rb.AddForce(transform.up * boost);
                Debug.Log("IsGrounded2Omlaag");
                y = 1;
            }
        }
               
    }

    void Update()
    {
        if (Time.time > bounceTime)
        {
            bounceTime = Time.time + timeBetweenBounce;
        }

        if (Time.timeScale == 0)
        {
            
        }

    }

    void GroundCheck()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider2.position, colliderRadius, groundLayer);

        if (colliders.Length > 0)
        {
            isGrounded = true;
        }
    }

    void GroundCheck2()
    {
        Collider2D[] colliders2 = Physics2D.OverlapCircleAll(groundCheckCollider.position, colliderRadius, groundLayer);

        if (colliders2.Length > 0)
        {
            isGrounded2 = true;
        }
    }
}



