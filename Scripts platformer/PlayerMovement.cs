
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] bool isGrounded = false;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    //camera
    private Vector2 playerDirection;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float colliderRadius = 0.2f;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0f;
    }

    
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        isGrounded = false;
        GroundCheck();
        
        if(Input.GetKey("space") && (isGrounded == true))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            
        }
        
    }

    
    void GroundCheck()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, colliderRadius, groundLayer);
        
        if(colliders.Length>0)
        {
            isGrounded = true;
        }
    }
       
    
}
