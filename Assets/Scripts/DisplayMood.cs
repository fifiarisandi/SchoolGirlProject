using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMood : MonoBehaviour
{
    GameManager gm;
    Image moodBar;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        moodBar = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moodBar.fillAmount = gm.amountLeft / 100;
        
    }
}
