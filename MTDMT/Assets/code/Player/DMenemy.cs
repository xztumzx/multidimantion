using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMenemy : MonoBehaviour
{
    public float damage = 25f;

    private void OnTriggerEnter(Collider other)
    {
        FloatingHPBar enemyHp = other.GetComponent<FloatingHPBar>();

        if (enemyHp != null)
        {
            enemyHp.takeDamage(damage);
        }
    }
}

