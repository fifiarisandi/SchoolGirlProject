using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    GameManager gm;
    float barChange;
    float moodChange;
    //float energyChange;
      float timeEnter;
      int enterHour;
      int enterMin;
    

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
                    //get the timestamp

                    float hr = gm.GetHour();
                    enterHour = Mathf.FloorToInt(hr);
                    enterMin = Mathf.FloorToInt(gm.GetMinutes());

                    if (enterHour == 9 && enterMin <= 15) {
                        //ontime
                        barChange = 40;
                        //moodChange = 40;
                    }
                    else if (enterHour == 9 && enterMin <= 30) {
                        //lateabit
                        barChange = 50;
                        //moodChange = 40;
                    } 
                    else {
                        //notasschedule
                        barChange = 50;
                        //moodChange = 50;
                    }
                    gm.TakeDamage(barChange);
                   // gm.TakeDamage(moodChange);
                    SceneManager.LoadScene ("Library");
                } 
                else if (hit.collider.gameObject.name == "Classroom door") {
                    //timeEnter =gm. (get the timestamp)
                    
                    if (enterHour == 11 && enterMin <= 15) {
                        //ontime
                        barChange = 40;
                        //moodChange = 40;
                    }
                    else if (enterHour == 11 && enterMin <= 30) {
                        //lateabit
                        barChange = 50;
                        //moodChange = 40;
                    } 
                    else {
                        //notasschedule
                        barChange = 50;
                        //moodChange = 50;
                    }
                    gm.TakeDamage(barChange);
                   // gm.TakeDamage(moodChange);

                    SceneManager.LoadScene ("Classroom");
                } 
                else if (hit.collider.gameObject.name == "Cafe door") {
                    //timeEnter =gm. (get the timestamp)
                    
                    if (enterHour == 13 && enterMin <= 15) {
                        //ontime
                        barChange = 30;
                        //moodChange = 40;
                    }
                    else if (enterHour == 13 && enterMin <= 30) {
                        //lateabit
                        barChange = 20;
                        //moodChange = 40;
                    } 
                    else {
                        //notasschedule
                        barChange = 10;
                        moodChange = 50;
                    }
                    gm.TakeDamage(moodChange);
                    gm.Healing(barChange);

                    SceneManager.LoadScene ("Cafeteria");
                } 
                  
                else if (hit.collider.gameObject.name == "Gym door") {
                    //timeEnter =gm. (get the timestamp)
                    
                    if (enterHour == 16 && enterMin <= 15) {
                        //ontime
                        barChange = 30;
                        //moodChange = 40;
                    }
                    else if (enterHour == 16 && enterMin <= 30) {
                        //lateabit
                        barChange = 20;
                        //moodChange = 40;
                    } 
                    else {
                        //notasschedule
                        barChange = 10;
                        moodChange = 50;
                    }
                    gm.TakeDamage(moodChange);
                    gm.Healing(barChange);

                    SceneManager.LoadScene ("Gym");
                }

            }
        }
    }
}
