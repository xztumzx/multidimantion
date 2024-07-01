using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : CharacterStats
{
    public HpBar healthBar;

    public StaminaBar staminaBar;

    public int AttackCost;
    public int ChargeRate;
    public KeyCode dashKey = KeyCode.LeftShift;

    private Coroutine recharge;

    //private bool staminaExhausted;

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

    /*public void TakeStaminaDamage(int damage)
    {
        if (Input.GetKeyDown("LeftShift"))
        {
            currentStamina -= damage;
            
            staminaBar.SetCurrentStamina(currentStamina);
        }
        
    }*/

    void Update()
    {
        if (Input.GetKeyDown(dashKey))
        {
            Debug.Log("Attack!");

            currentStamina -= AttackCost;
            if (currentStamina < 0) currentStamina = 0;
            staminaBar.SetCurrentStamina(currentStamina);

            if (recharge != null) StopCoroutine(recharge);
            recharge = StartCoroutine(RechargeStamina());
        }
    }

    /*void Update() // bug
    {
        if(Input.GetKeyDown(dashKey) && !staminaExhausted)
        {
            Debug.Log("Attack!");
            if (currentStamina > 0)
            {
                currentStamina -= AttackCost;
            }
            else
            {
                staminaExhausted = true;
            }
           
            if (currentStamina < 0) currentStamina = 0;
            staminaBar.SetCurrentStamina(currentStamina);

            if (recharge != null) StopCoroutine(recharge);
            recharge = StartCoroutine(RechargeStamina());
        }
        else
        {
            if (currentStamina < maxStamina)
            {
                recharge = StartCoroutine(RechargeStamina());
            }
            else
            {
                staminaExhausted = false;
            }
        }
        
    }*/

    private IEnumerator RechargeStamina()
    {
        yield return new WaitForSeconds(3f);

        while(currentStamina < maxStamina)
        {
            currentStamina += ChargeRate;
            if(currentStamina > maxStamina) currentStamina = maxStamina;
            staminaBar.SetCurrentStamina(currentStamina);
            yield return new WaitForSeconds(.1f);
        }
    }
}
