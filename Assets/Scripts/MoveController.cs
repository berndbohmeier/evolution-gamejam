using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {

    public bool facingRight = true;
    //public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public float wallForce;
    public Transform groundCheck;
    public Transform leftCheck;
    public Transform rightCheck;
    public bool wallJump;
    public int timesJump;

    private int jumpsLeft;

    private bool grounded = false;
    private bool leftGrounded = false;
    private bool rightGrounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Awake()
    {
        //anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        if (wallJump)
        {
            leftGrounded = Physics2D.Linecast(transform.position, leftCheck.position, 1 << LayerMask.NameToLayer("Ground"));
            rightGrounded = Physics2D.Linecast(transform.position, rightCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        }
    }

    void FixedUpdate()
    {

    }

    public void Jump()
    {
        //anim.SetTrigger("Jump");
        if (grounded || rightGrounded || leftGrounded)
        {
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jumpsLeft = timesJump-1;
            if (leftGrounded)
            {
                rb2d.AddForce(new Vector2(wallForce, 0));
            }
            if (rightGrounded)
            {
                rb2d.AddForce(new Vector2(-wallForce, 0));
            }
        }
        else if (jumpsLeft > 0)
        {
            rb2d.velocity = new Vector2 (rb2d.velocity.x, 0);
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jumpsLeft--;
        }
        
    }

    public void Move(float h)
    {
        //anim.SetFloat("Speed", Mathf.Abs(h));

        if(leftGrounded && h < 0){
            h = 0;
        }

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}

