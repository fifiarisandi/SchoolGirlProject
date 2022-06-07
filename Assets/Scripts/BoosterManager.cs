using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoosterManager : MonoBehaviour
{
    Image boosterImg;
    GameManager gm;
    float boosterValue = 10;

   private void Awake() {
        boosterImg = GameObject.FindGameObjectWithTag("Booster").GetComponent<Image>();
        boosterImg.sprite = Resources.Load<Sprite>("EnergyBooster");

    
    void useBooster() {
        gm.Healing(boosterValue);
    }

        // if (boosterImgArray == null) {
        //     boosterImgArray = GameObject.FindGameObjectWithTag("Booster");
        // }
        // foreach (Image boosterImg in boosterImgArray) {
        //     if (boosterImg.Sprite == "Square") {
        //         boosterImg.sprite = Resources.Load<Sprite>("EnergyBooster");
        //     }    
        // }
   }
}
