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
    public float amountLeft = 100;
    public float boosterEarned; 

    //GameOver
    string timeNow;
    Boolean isGameOver;
   
    
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

        //checkBar
        // if (amountLeft <= 50) {
        //     Debug.Log("You are almost running out of energy. Make better choices! ");
        // }

        //GameOver
        CheckGameOver();
    }

    public float TakeDamage(float damage) {
        amountLeft -= damage;
        return amountLeft;

    }

    public float Healing(float healPoint) {
        amountLeft += healPoint;
        amountLeft = Mathf.Clamp(amountLeft, 0, 100);
        return amountLeft;
    }

    void LibraryGameListener() {
        //booster scene
        boosterEarned = 10;
        Healing(boosterEarned);
        SceneManager.LoadScene("CongratsLibrary");

    }

    //Gameover
    public void CheckGameOver () {
        timeNow = Clock24H();
        if (timeNow == "20:00") {
            isGameOver = true;
            SceneManager.LoadScene("GameOver");
        }
        if (amountLeft <= 0) {
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
    
    
    
}
