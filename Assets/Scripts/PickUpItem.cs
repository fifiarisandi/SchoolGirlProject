using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    
    public Item itemData;
    
    public GameObject pickEffect;

    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            //For picking up the object
            Instantiate(pickEffect, transform.position, Quaternion.identity);

            //For destroying the object after it has been picked up
            Destroy(gameObject); 

            GameManager.instance.AddItem(itemData);

        }
    }
}
