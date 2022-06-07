using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    GameManager gm;
    float energyChange;
    float energyLeft;
    // public delegate void clickDoorBarModifierDelegate();
    // public static event clickDoorBarModifierDelegate doorBarModifierEvent;

    void Start() {
        gm = FindObjectOfType<GameManager>();
    }

    // public void ModifyBar() {

    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {

                if (hit.collider.gameObject.name == "Library door") {
                    energyChange = 20;
                    gm.TakeDamage(energyChange);
                    SceneManager.LoadScene ("Library");
                } 
                // else if (hit.collider.gameObject.name == "Classroom door") {
                //     SceneManager.LoadScene ("Classroom");
                // } 
                // else if (hit.collider.gameObject.name == "Cafe door") {
                //     SceneManager.LoadScene ("Cafeteria");
                // } else if (hit.collider.gameObject.name == "Gym door") {
                //     SceneManager.LoadScene ("Gym");
                // }

            }
        }
    }
}
