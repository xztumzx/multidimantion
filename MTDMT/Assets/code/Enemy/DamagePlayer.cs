using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public int damage = 25;

    private void OnTriggerEnter(Collider other)
    {
        PlayerStats playerState = other.GetComponent<PlayerStats>();

        if (playerState != null)
        {
            playerState.TakeDamage(damage);
        }
    } 
}
