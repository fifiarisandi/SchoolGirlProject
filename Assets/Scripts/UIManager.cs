using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inventoryMenu;
    
    
    private void Start()            //Should change it to public later
    {
        inventoryMenu.gameObject.SetActive(false);
    }

    
    private void Update()           //Should change it to public later
    {
        InventoryControl();
    }

    //For controlling the inventory
    private void InventoryControl()
    {
        if(Input.GetKeyDown(KeyCode.I))     //To activate and deactivate inventory in the game
        {
            //Game is paused if "i" is pressed
            if(GameManager.instance.isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

            //Game resumes when "i" is pressed again after using the inventory

        }
    }

    //For resuming the game
    private void Resume()
    {
        inventoryMenu.gameObject.SetActive(false);

        //For the passage of time when game resumes
        Time.timeScale = 1.0f;             

        //To resume the game
        GameManager.instance.isPaused = false;            
    }

    //For pausing the game
    private void Pause()
    {
        inventoryMenu.gameObject.SetActive(true);

        //For the passage of time when game pauses
        Time.timeScale = 0.0f;

        //To pause the game
        GameManager.instance.isPaused = true;   
    }
}
