using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    GameManager gm;
    float energyChange;
    float timeEnter;
    

    void Start() {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {

                if (hit.collider.gameObject.name == "Library door") {
                    //timeEnter =gm. (get the timestamp)
                    
                    if (timeEnter <= gm.schedule1) {
                        energyChange = 20;
                    }
                    else if (timeEnter > gm.schedule1 && timeEnter <= (gm.schedule1 + 0.15)) {
                        energyChange = 30;
                    } 
                    else {
                        energyChange = 50;
                    }
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
