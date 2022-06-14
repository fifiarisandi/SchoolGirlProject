using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibraryScoreManager : MonoBehaviour
{
    public delegate void miniGameStatusDelegate();
    public static event miniGameStatusDelegate gameStatusEvent;
    private Inventory inventory;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void CheckBubbles() {
        if (inventory.isFull[3] == true) {
            if (gameStatusEvent != null) {
                
                gameStatusEvent();
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        Invoke("CheckBubbles", 5f);
    }
}
