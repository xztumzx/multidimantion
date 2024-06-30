using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    //public Image healthFill;
    //public int maxHealth;
    //public int currentHealth; // (เลือดไม่เริ่มใหม่) 

    public Slider slider;


    private void Start()
    {
        //currentHealth = maxHealth;
        slider = GetComponent<Slider>();
    }

    public void SetMaxHealth(int maxHealth)
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
    }

    public void SetCurrentHealth(int currentHealth)
    {
        slider.value = currentHealth;
    }

    /*void Update()
    {
        if (slider.value != currentHealth)
        {
            slider.value = currentHealth;

        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            takeDamage(25);
        }
    }
    void takeDamage(int damage)
    {
        currentHealth -= damage;
    }*/
}
