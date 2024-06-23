using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwithfreelook : MonoBehaviour
{
    public float moveSpeed = 5f;  // ความเร็วในการเคลื่อนที่
    public float rotateSpeed = 100f;  // ความเร็วในการหมุน
    public float runSpeedMultiplier = 2f;  // ตัวคูณความเร็วเมื่อวิ่ง

    private Rigidbody rb;
    private Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;  // หากใช้ MainCamera ให้ใช้คำสั่งนี้ หากไม่ใช้ให้กำหนด mainCamera เอง
    }

    void FixedUpdate()
    {
        // รับอินพุตจากผู้เล่น
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        bool isRunning = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);  // ตรวจสอบว่ากด Shift หรือไม่

        // หาทิศทางของกล้อง
        Vector3 cameraForward = mainCamera.transform.forward;
        Vector3 cameraRight = mainCamera.transform.right;
        cameraForward.y = 0f;  // ไม่สนใจแกน Y ในการหมุนตามกล้อง
        cameraRight.y = 0f;  // ไม่สนใจแกน Y ในการหมุนตามกล้อง

        // คำนวณทิศทางการเคลื่อนที่ของตัวละคร
        Vector3 movement = Vector3.zero;
        movement = moveVertical * cameraForward.normalized + moveHorizontal * cameraRight.normalized;

        // คำนวณการหมุนตามกล้อง
        if (movement != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement);
            rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, newRotation, rotateSpeed * Time.fixedDeltaTime));
        }
        
        // ตรวจสอบว่าวิ่งหรือไม่
        if (isRunning)
        {
            movement *= runSpeedMultiplier;  // เพิ่มความเร็วเมื่อกด Shift
        }

        // คำนวณการหมุนตามกล้อง
        if (movement != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement);
            rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, newRotation, rotateSpeed * Time.fixedDeltaTime));
        }
        // คำนวณการเคลื่อนที่และแก้ไขตำแหน่งของตัวละคร
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
