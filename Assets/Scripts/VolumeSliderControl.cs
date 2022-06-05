using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderControl : MonoBehaviour
{
    [SerializeField] private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
            slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeMasterVolume(val));
    }

}
