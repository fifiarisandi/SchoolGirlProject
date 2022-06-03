using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerintheHallway : MonoBehaviour
{

    private bool isontheGround;
    private string FLOOR_TAG = "Floor";

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.CompareTag(FLOOR_TAG)) 
            isontheGround = true;
    }
}
