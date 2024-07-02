using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animdash : MonoBehaviour
{
    public Animator anim;
    public CharacterController characontroll;
    private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        characontroll = GetComponent<CharacterController>();
        playerStats = FindObjectOfType<PlayerStats>();

    }

    // Update is called once per frame
    void Update()
    {
        animda();

    }
    void animda() 
    {
        if (playerStats != null && playerStats.CanDash())
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("dash", true);
            }
            else { anim.SetBool("dash", false); }

        }
        else { anim.SetBool("dash", false); }

    }


}    

