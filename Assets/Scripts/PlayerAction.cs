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
    //private WALK_ANIMATION = "Walk";
    private SpriteRenderer sr;

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
        //float h = Input.GetAxis("Horizontal");
        //Vector2 pos = transform.position;
        //pos.x += h * speed * Time.deltaTime;
        //pos.y =0;
        //transform.position = pos;
        PlayerMoveKeyboard();
        //AnimatePlayer();
        
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


    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump")) {
            theBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }
    }
}
