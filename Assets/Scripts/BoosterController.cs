using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoosterController : MonoBehaviour
{
    GameManager gm;
    //int counting = 1;
    // int boosterCount;

    // private void Start() {
    //     boosterCount = gm.CountBoosterScene(counting);
    // }


    public void BacktoHallway() {
        SceneManager.LoadScene("TheHallway");
        //gm.CountBoosterScene(1);
    }

    // public void CountEntry() {
    //     gm.CountEntered(counting);
    // }

}
