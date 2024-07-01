using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{

    public HpBar healthBar;
    public StaminaBar staminaBar;

    private void Awake()
    {
        healthBar = FindObjectOfType<HpBar>();
        staminaBar = FindObjectOfType<StaminaBar>();
    }
    void Start()
    {
        maxHealth = SetMaxHealthFromHealthLevel();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        maxHealth = SetMaxStaminaFromStaminaLevel();
        currentStamina = maxStamina;
        staminaBar.SetMaxStamina(maxStamina);
    }

    private int SetMaxHealthFromHealthLevel()
    {
        maxHealth = healthLeval * 10;
        return maxHealth;
    }

    private int SetMaxStaminaFromStaminaLevel()
    {
        maxStamina = staminalevel * 10;
        return maxStamina;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetCurrentHealth(currentHealth);
    }

    public void TakeStaminaDamage(int damage)
    {
        currentStamina -= damage;

        staminaBar.SetCurrentStamina(currentStamina);
    }
}
