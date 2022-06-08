using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoosterPage : MonoBehaviour
{
    GameManager gm;

    private void Start() {
        gm = FindObjectOfType<GameManager>();
    }

     public void BoosterCoolBtn() {
        SceneManager.LoadScene("TheHallway");
        //Debug.Log("Button clicked!");
        //gm.PutEnergyBoosteronScene();   

    }




}
