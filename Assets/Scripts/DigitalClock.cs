using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalClock : MonoBehaviour
{
    GameManager tm;
    Text display;

    // Start is called before the first frame update
    void Start()
    {
        tm = FindObjectOfType<GameManager>();
        display = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        display.text = tm.Clock24H();
    }
}
