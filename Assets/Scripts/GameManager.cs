using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //timekeeper vars
    public const int hoursInDay = 24;
    public const int minutesInHour = 60;
    float dayDuration = 1200f;
    float totalTime = 0;
    float currentTime = 0;

    
    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        //timekeeper 
        totalTime += Time.deltaTime;
        currentTime = totalTime % dayDuration;

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
