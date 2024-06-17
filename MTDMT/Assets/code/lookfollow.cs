using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookfollow: MonoBehaviour
{
    void Update()
    {
        // รับตำแหน่งของกล้อง
        Camera mainCamera = Camera.main;

// ทำให้วัตถุหันหน้าเข้าหากล้อง
if (mainCamera != null)
{
    Vector3 direction = mainCamera.transform.position - transform.position;
    direction.x = direction.z = 0.0f; // ล็อคแกน X และ Z
    transform.LookAt(mainCamera.transform.position - direction);
    transform.Rotate(0, 180, 0); // ปรับหมุนให้หน้าเข้าหากล้องถูกต้อง
}
    }
}
