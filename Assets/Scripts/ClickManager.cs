using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    GameManager gm;
    float energyChange;
    float moodChange;
    //float energyChange;
    float timeEnter;
    int enterHour;
    int enterMin;   

    //checking Enter
    int counting;
    Boolean isOver;

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

                if (hit.collider.gameObject.name == "Classroom door") {
                    //get the timestamp

                    enterHour = Mathf.FloorToInt(gm.GetHour());
                    enterMin = Mathf.FloorToInt(gm.GetMinutes());
                    isOver = gm.CheckResult();
                    //counting = 1;

                    //on time 9 to 9.15
                    if (enterHour == 9 ) {
                        if (enterMin >= 0 && enterMin <= 15) {
                            energyChange = 40;
                            moodChange = 30;
                        }
                        //late a bit 9.15 to 9.30
                        else if (enterMin > 15 && enterMin <= 30) {
                            energyChange = 50;
                            moodChange = 40;
                        }
                        //after 9.30 (not as schedule)
                        else {
                            energyChange = 60;
                            moodChange = 50;
                        }
                    }
                    //not as schedule
                    else {
                        energyChange = 60;
                        moodChange = 50;
                    }
                    gm.TakeDamageEnergy(energyChange);
                    gm.TakeDamageMood(moodChange);
                    
                    if (isOver == false) {
                        SceneManager.LoadScene ("Classroom");
                    }
                } 
                else if (hit.collider.gameObject.name == "Library door") {
                    //get the timestamp

                    enterHour = Mathf.FloorToInt(gm.GetHour());
                    enterMin = Mathf.FloorToInt(gm.GetMinutes());
                    isOver = gm.CheckResult();
                    //counting = 1;

                    //on time 11 to 11.15
                    if (enterHour == 11 ) {
                        if (enterMin >= 0 && enterMin <= 15) {
                            energyChange = 40;
                            moodChange = 30;
                        }
                        //late a bit 11.15 to 11.30
                        else if (enterMin > 15 && enterMin <= 30) {
                            energyChange = 50;
                            moodChange = 40;
                        }
                        //after 11.30 (not as schedule)
                        else {
                            energyChange = 60;
                            moodChange = 50;
                        }
                    }
                    //not as schedule
                    else {
                        energyChange = 60;
                        moodChange = 50;
                    }
                    gm.TakeDamageEnergy(energyChange);
                    gm.TakeDamageMood(moodChange);
                    
                    if (isOver == false) {
                        SceneManager.LoadScene ("Library");
                    }
                } 
                else if (hit.collider.gameObject.name == "Cafe door") {
                    //get the timestamp

                    enterHour = Mathf.FloorToInt(gm.GetHour());
                    enterMin = Mathf.FloorToInt(gm.GetMinutes());
                    counting = 1;

                    //on time 13 to 13.15
                    if (enterHour == 13 ) {
                        if (enterMin >= 0 && enterMin <= 15) {
                            energyChange = 30;
                            moodChange = 20;
                            //gm.CountEnteredOnTime(counting);
                        }
                        //late a bit 13.15 to 13.30
                        else if (enterMin > 15 && enterMin <= 30) {
                            energyChange = 20;
                            moodChange = 10;
                        }
                        //after 13.30 (not as schedule)
                        else {
                            energyChange = 0;
                            moodChange = 0;
                        }
                    }
                    //not as schedule
                    else {
                        energyChange = 0;
                        moodChange = 0;
                    }
                    gm.HealingEnergy(energyChange);
                    gm.HealingMood(moodChange);
                    
                    if (isOver == false) {
                        SceneManager.LoadScene ("Cafeteria");
                    }
                } 
                  
                else if (hit.collider.gameObject.name == "Gym door") {
                    //get the timestamp

                    enterHour = Mathf.FloorToInt(gm.GetHour());
                    enterMin = Mathf.FloorToInt(gm.GetMinutes());
                    counting = 1;

                    //on time 16 to 16.15
                    if (enterHour == 16) {
                        if (enterMin >= 0 && enterMin <= 15) {
                            energyChange = 30;
                            moodChange = 20;
                            //gm.CountEnteredOnTime(counting);
                            //gm.isEnteredOnTime = true;
                        }
                        //late a bit 16.15 to 16.30
                        else if (enterMin > 15 && enterMin <= 30) {
                            energyChange = 20;
                            moodChange = 10;
                        }
                        //after 16.30 (not as schedule)
                        else {
                            energyChange = 0;
                            moodChange = 0;
                        }
                    }
                    //not as schedule
                    else {
                        energyChange = 0;
                        moodChange = 0;
                    }
                    gm.HealingEnergy(energyChange);
                    gm.HealingMood(moodChange);
                    if (isOver == false) {
                        SceneManager.LoadScene ("Gym");
                    }
                }

            }
        }
    }

    public void CheckSchedule() {
        SceneManager.LoadScene("Schedule");

    }

    public void CheckGuideline() {
        SceneManager.LoadScene("Guideline");

    }

}
