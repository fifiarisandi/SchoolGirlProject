using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHallway : MonoBehaviour
{
    // private bool isontheGround;
    // private string FLOOR_TAG = "Floor";
    // private Vector3 playerRotation;
    // private float rotationSpeed = 20f;

    // private Vector2 target;

    // public float speed = 10f;
    // Vector2 lastClickedPos;
    // bool moving;



    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0)) {
        //     lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     moving = true;
        // }

        // if (moving && (Vector2)transform.position != lastClickedPos) {
        //     float step = speed * Time.deltaTime;
        //     transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
        // } else {
        //     moving = false;
        // }
        
        // Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // if (Input.GetMouseButtonDown(0)) {
        //     target = new Vector2(mousePos.x, mousePos.y);
        // }

        // transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);


        // playerRotation = new Vector3(0f, Input.GetAxis("Horizontal"), 0f);
        // transform.Rotate(playerRotation * rotationSpeed * Time.deltaTime);

        // if (Input.GetKey(KeyCode.Space)) {

        //     RaycastHit2D hit = Physics2D.Raycast(transform.position, )
        // }
    }

    // private void OnCollisionEnter2D(Collision2D collision) {

    //     if (collision.gameObject.CompareTag(FLOOR_TAG)) 
    //         isontheGround = true;
    // }
}
