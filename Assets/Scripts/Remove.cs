using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    private Inventory inventory;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")) {

            for (int i = 0; i < inventory.slots.Length; i++) {
                 if (inventory.isFull[i] == true) {
                     //item can be deleted
                     Destroy(inventory.slots[i].transform.GetChild(i).gameObject);
                     inventory.isFull[i] = false;
                     Destroy(gameObject);
                     break;
                 }
             } 
        }

    }
}
