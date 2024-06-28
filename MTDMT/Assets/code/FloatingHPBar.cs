using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHPBar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateHPBar(float currentValue, float maxValue)
    {
        slider.value = currentValue / maxValue;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
