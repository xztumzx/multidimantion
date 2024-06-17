using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontoler : MonoBehaviour
{
    public float speed = 5.0f; // ความเร็วในการเดินของตัวละคร

    private Rigidbody rb;
    private Transform mainCameraTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // เข้าถึง Rigidbody ของตัวละคร
        mainCameraTransform = Camera.main.transform; // อ้างอิงถึงกล้องหลักในซีน
    }

    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // หาทิศทางการเคลื่อนไหวตามการกดปุ่ม
        Vector3 forward = mainCameraTransform.forward;
        Vector3 right = mainCameraTransform.right;

        // ทำให้ทิศทางการเคลื่อนไหวอยู่ในแนวระนาบ (ล็อคแกน Y)
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 movement = forward * moveVertical + right * moveHorizontal;

        if (movement.magnitude > 0)
        {
            // หมุนตัวละครให้หันหน้าไปตามทิศทางการเคลื่อนไหว
            transform.rotation = Quaternion.LookRotation(movement);

            // เคลื่อนที่ตัวละคร
            rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
        }
    }
}
