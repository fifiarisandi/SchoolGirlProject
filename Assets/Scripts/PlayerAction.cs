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
    private string KBUBBLE_TAG = "KnowledgeBubble";
    private string RBUBBLE_TAG = "RandomBubble";

    //private SpriteRenderer otherSprite;

    private int knowledgeEarned;


    private void Awake()
    {
        theBody = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        knowledgeEarned = 0;
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

        if (collision.CompareTag(KBUBBLE_TAG)) { 
            if (knowledgeEarned < 10 && knowledgeEarned >= 0) {
                knowledgeEarned ++;
                Debug.Log("Knowledge is increasing! " + knowledgeEarned);
            }
            else {
               Debug.Log("Congrats! You received a mental capacity bonus! " + knowledgeEarned);
               //game stop, and go to result screen
            }
        }
        else if (collision.CompareTag(RBUBBLE_TAG)) {
        if (knowledgeEarned > 0 && knowledgeEarned <= 10) {
                knowledgeEarned --;
                Debug.Log("Knowledge is decreasing! " + knowledgeEarned);
        }
        }
        Destroy(collision.gameObject);
    }       
    
}
