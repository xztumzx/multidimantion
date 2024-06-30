using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animdash : MonoBehaviour
{
    public Animator anim;
    public CharacterController characontroll;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        characontroll = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("dash", true);
        }
        else { anim.SetBool("dash", false); }

    }
}    

