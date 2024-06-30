using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control1 : MonoBehaviour
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
        
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("Moving a", true);
        }
        else { anim.SetBool("Moving a", false); }

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Moving d", true);
        }
        else { anim.SetBool("Moving d", false); }
    }
}
