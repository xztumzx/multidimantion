using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash1 : MonoBehaviour
{
    public float dashSpeed = 20f;       // ��������㹡�� dash
    public float dashDuration = 0.2f;   // ��������㹡�� dash
    public KeyCode dashKey = KeyCode.LeftShift; // ���������㹡�� dash

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
        rb.velocity = Vector3.zero;  // ��ش�������͹���
    }
}