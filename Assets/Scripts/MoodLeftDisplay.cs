using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodLeftDisplay : MonoBehaviour
{
    GameManager gm;
    Text display;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        display = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        display.text = gm.MoodLeft(); 
    }
}
