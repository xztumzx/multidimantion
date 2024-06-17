using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
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
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Moving s", true);
        }
        else { anim.SetBool("Moving s", false); }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Moving w", true);
        }
        else { anim.SetBool("Moving w", false); }
    }
}
