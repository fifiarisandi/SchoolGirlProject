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
    float dayDuration = 600f;
    float totalTime = 0;
    float currentTime = 0;

    //statsBar
    public float amountLeftEnergy = 100;
    public float amountLeftMood = 100;
    public float boosterEarned; 

    //GameOver
    string timeNow;
    public Boolean isGameOver;
    int checkHour;
    int checkMin;
   
    
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

        CheckLoadScene();

    }

    public float TakeDamageEnergy(float damage) {
        amountLeftEnergy -= damage;
        return amountLeftEnergy;

    }

    public float HealingEnergy(float healPoint) {
        amountLeftEnergy += healPoint;
        amountLeftEnergy = Mathf.Clamp(amountLeftEnergy, 0, 100);
        return amountLeftEnergy;
    }

     public float TakeDamageMood(float damage) {
        amountLeftMood -= damage;
        return amountLeftMood;

    }

    public float HealingMood(float healPoint) {
        amountLeftMood += healPoint;
        amountLeftMood = Mathf.Clamp(amountLeftMood, 0, 100);
        return amountLeftMood;
    }

    void LibraryGameListener() {
        SceneManager.LoadScene("CongratsBooster");

    }

    //Gameover
    public Boolean CheckResult() {
        timeNow = Clock24H();
        isGameOver = false;
        
        if (timeNow == "19:00") {
            isGameOver = true;
        }
        else if (amountLeftEnergy <= 0 || amountLeftMood <= 0) {
            isGameOver = true;
        }
        return isGameOver;
        
    }

    public void CheckLoadScene() {
        if (CheckResult() == true) {
            SceneManager.LoadScene("GameOver");
        }
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

    public string EnergyLeft() {
        return Mathf.FloorToInt(amountLeftEnergy).ToString();
    }

    public string MoodLeft() {
        return Mathf.FloorToInt(amountLeftMood).ToString();
    }

    public string Commentary() {
        
        if (amountLeftEnergy <=30 || amountLeftMood <= 30) {
            return ("You made it, but it could've been better! Make better choices next time!");
        }
        else {
            return ("You made good choices!");
        }
    }
    
    
    
}
