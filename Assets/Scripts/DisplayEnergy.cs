using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEnergy : MonoBehaviour
{
    GameManager gm;
    Image energyBar;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        energyBar = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        energyBar.fillAmount = gm.energyAmount / 100;
    }

}
