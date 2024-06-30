using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHPBar : MonoBehaviour
{
    public Slider hpSlider;
    public float maxHealth = 100f;
    public float health;

    void Start()
    {
         health = maxHealth;
    }

    void Update()
    {
         if (hpSlider.value != health)
        {
            hpSlider.value = health;

        }

         if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(10);
        }
    }

    void takeDamage(float damage)
    {
        health -= damage;
    }
}
