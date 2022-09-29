using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
                        /*Declaring Data Members for player*/
    [SerializeField]
    private float moveForce = 22f;
    [SerializeField]
    private float jumpForce = 11f;
    private float moveX;
    private Rigidbody2D mybody2d; 
    private Animator anim;
    private SpriteRenderer sprite_R;
    private string WalkAnimation="Walk";
    private bool isGrounded=true;
    private string GROUND_TAG = "Ground";
    private string Enemy_TAG = "Enemy";
    private void Awake()
    {
                // assigning  Reference to Components
        mybody2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite_R = GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
       

    }

    private void FixedUpdate()
    {
        playerjump(); // this function for player jump (vertical movement)
    }
    // Update is called once per frame
    void Update()
    {
        playerMovement(); 
        AnimatePlayer();
    }
    void playerMovement()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveX, 0f, 0f) * Time.deltaTime *moveForce;
    }
    void playerjump() 
    {
        
        if (Input.GetButtonDown("Jump")&& isGrounded==true) 
        {
            isGrounded = false;
            mybody2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
    void AnimatePlayer()
    {
        // we are going to right side
        if(moveX>0)
        {
            anim.SetBool(WalkAnimation, true);
            sprite_R.flipX = false;

        }
        // we are going to left side
        else if (moveX<0)
        {
            anim.SetBool(WalkAnimation, true);
            sprite_R.flipX = true;

        }
        else 
        {
            anim.SetBool(WalkAnimation, false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;
           
           
        }
        if (collision.gameObject.CompareTag(Enemy_TAG))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Enemy_TAG))
            Destroy(gameObject);
    }
} //class
