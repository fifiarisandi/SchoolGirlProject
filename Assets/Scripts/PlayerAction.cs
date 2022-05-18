using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    //public float speed = 5f;
    public float moveForce = 10f;
    public float jumpForce = 11f;
    private float movementX;

    private Rigidbody2D theBody;
    private Animator anime;
    private string WALK_ANIMATION = "Walk";
    private SpriteRenderer sr;
    private bool isontheGround = true;
    private string GROUND_TAG = "Ground";
    private string BUBBLE_TAG = "Bubble";


    private void Awake()
    {
        theBody = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        
    }

    private void FixedUpdate()
    {
        PlayerJump();

    }


    void PlayerMoveKeyboard() 
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;

    }
    
    void AnimatePlayer()
    {
        if (movementX < 0) {
            anime.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        else if (movementX > 0) {
            anime.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else {
            anime.SetBool(WALK_ANIMATION, false);
        }

    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isontheGround) {

            isontheGround = false;
            theBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        if (collision.gameObject.CompareTag(GROUND_TAG)) 
            isontheGround = true;

    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag(BUBBLE_TAG))
            Destroy(collision.gameObject);
        
    }
    
}
