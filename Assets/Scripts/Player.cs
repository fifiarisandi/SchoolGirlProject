//C# script for testing the player on click event for changing the mental health bar value

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int MaximumHealth = 100;             //For storing the maximum health value

    public int CurrentHealth;               //For storing the current health value
     
    public MentalHealthBar HealthBar;                 //For calling the MentalHealthBar to this script

    // Start is called before the first frame update
    void Start()
    {
        
        //CurrentHealth = MaximumHealth;
        HealthBar.MaxHealth(MaximumHealth);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                TakeDamage(10);
            }

    }

    void TakeDamage(int damage)
        {
            CurrentHealth += damage;

            HealthBar.SetHealth(CurrentHealth);
        }
}
