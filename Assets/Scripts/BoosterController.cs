using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoosterController : MonoBehaviour
{

    public void BacktoHallway() {
        SceneManager.LoadScene("TheHallway");
    }

}
