using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //timeKeeper
    public const int hoursInDay = 24;
    public const int minutesInHour = 60;
    float dayDuration = 1200f;
    float totalTime = 0;
    float currentTime = 0;

    //schedule
    public float schedule1 = 9.15f;
    public float schedule2 = 11;
    public float schedule3 = 13;
    public float schedule4 = 14;
    public float schedule5 = 16;

    //energyBar
    //public Image energyBar;
    public float energyAmount = 100;
    
   
    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    void OnEnable() {
       LibraryScoreManager.gameStatusEvent += LibraryGameListener;
    }

    void OnDisable() {
        LibraryScoreManager.gameStatusEvent -= LibraryGameListener;
    }

    void Update()
    {
        //timeKeeper 
        totalTime += Time.deltaTime;
        currentTime = totalTime % dayDuration;

        //energyBar
        if (energyAmount == 20) {
            Debug.Log("You are almost running out of energy. It's time for a booster!");
        }
        if (energyAmount <= 0) {
            //GameOver scene
            Debug.Log("You are running out of energy!");
        }
    }

    public float TakeDamage(float damage) {
        energyAmount -= damage;
        return energyAmount;

    }

    public float Healing(float healPoint) {
        energyAmount += healPoint;
        energyAmount = Mathf.Clamp(energyAmount, 0, 100);
        return energyAmount;
    }

    void LibraryGameListener() {
        //booster scene
        SceneManager.LoadScene("CongratsLibrary");

    }


    public float GetHour() {
        return  ((currentTime * hoursInDay / dayDuration) + 9);
    }

    public float GetMinutes() {
        return ((currentTime * hoursInDay * minutesInHour / dayDuration) % minutesInHour);
    }

    public string Clock24H() {
        
        return Mathf.FloorToInt(GetHour()).ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00");
    }
    
    
    
}
