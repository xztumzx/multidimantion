﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
    public float dashSpeed = 20f;       // ¤ÇÒÁàÃçÇã¹¡ÒÃ dash
    public float dashDuration = 0.2f;   // ÃÐÂÐàÇÅÒã¹¡ÒÃ dash
    public KeyCode dashKey = KeyCode.LeftShift; // »ØèÁ·Õèãªéã¹¡ÒÃ dash

    private Rigidbody rb;
    private bool isDashing = false;
    private float dashTime;
    private Vector3 dashDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(dashKey) && !isDashing)
        {
            StartDash();
        }

        if (isDashing)
        {
            ContinueDash();
        }
    }

    void StartDash()
    {
        isDashing = true;
        dashTime = Time.time + dashDuration;
        dashDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        rb.velocity = dashDirection * dashSpeed;
    }

    void ContinueDash()
    {
        if (Time.time >= dashTime)
        {
            StopDash();
        }
    }

    void StopDash()
    {
        isDashing = false;
        rb.velocity = Vector3.zero;  // ËÂØ´¡ÒÃà¤Å×èÍ¹·Õè
    }
}