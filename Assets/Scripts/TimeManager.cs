using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public const int hoursInDay = 24;
    public const int minutesInHour = 60;
    public float dayDuration = 60f;
    public const float startHour = 8;
    public const float startMinute = 45;
    float totalTime = 0;
    float currentTime = 0;


    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        currentTime = totalTime % dayDuration;

    }

    public float GetHour() {
        return (currentTime * hoursInDay / dayDuration) + startHour;
    }

    public float GetMinutes() {
        return ((currentTime * hoursInDay * minutesInHour / dayDuration) % minutesInHour) + startMinute;
    }

    public string Clock24H() {
        
        return Mathf.FloorToInt(GetHour()).ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00");
    }

    
}
