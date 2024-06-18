using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Image hpFill;
    public float maxHp;
    public float currentHp; // (เลือดไม่เริ่มใหม่)

    void Start()
    {
        // currentHp = maxHp; //เลือดรีใหม่
    }
    void takeDamage(float damage)
    {
        currentHp -= damage;

        hpFill.fillAmount = currentHp * (1 / maxHp);
    }

    void takeHeal(float Heal)
    {
        currentHp += Heal;

        hpFill.fillAmount = currentHp * (1 / maxHp);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            takeHeal(20);
        }
    }
}
