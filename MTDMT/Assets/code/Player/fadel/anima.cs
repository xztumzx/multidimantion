using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anima : MonoBehaviour
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
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Moving", true);
        }
        else { anim.SetBool("Moving", false); }

    }
}

