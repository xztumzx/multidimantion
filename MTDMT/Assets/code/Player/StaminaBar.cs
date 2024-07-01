using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;


    private void Start()
    {
        //currentHealth = maxHealth;
        slider = GetComponent<Slider>();
    }

    public void SetMaxStamina(int maxStamina)
    {
        slider.maxValue = maxStamina;
        slider.value = maxStamina;
    }

    public void SetCurrentStamina(int currentStamina)
    {
        slider.value = currentStamina;
    }
}
