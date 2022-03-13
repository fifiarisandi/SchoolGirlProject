// C# Script for setting the control for the Mental health bar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MentalHealthBar : MonoBehaviour
{
    
    public Slider SlidControl;

    //For setting the maximum value for the mental health bar
    public void  MaxHealth(int MentalHealth)
        {
            SlidControl.maxValue = MentalHealth;
            SlidControl.value = MentalHealth;
        }

    //For setting the value for the mental health bar
    public void SetHealth(int MentalHealth)
        {
            SlidControl.value = MentalHealth;
        }

}    

