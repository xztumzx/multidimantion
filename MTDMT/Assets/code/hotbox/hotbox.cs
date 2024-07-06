using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotbox : MonoBehaviour
{
    public Collider hitbox; // ตัวแปรสำหรับเก็บ Collider ของ hitbox
    public float hotboxDuration = 1.0f; // ระยะเวลาที่จะเป็น hotbox
    public bool isHot = false; // ตรวจสอบว่าปัจจุบันเป็น hotbox หรือไม่

    private void Start()
    {
        if (hitbox == null)
        {
            hitbox = GetComponent<Collider>();
        }
    }

    public void ActivateHotbox()
    {
        if (!isHot)
        {
            StartCoroutine(HotboxRoutine());
        }
    }

    private IEnumerator HotboxRoutine()
    {
        isHot = true;
        ChangeToHotbox();
        yield return new WaitForSeconds(hotboxDuration);
        RevertToHitbox();
        isHot = false;
    }

    private void ChangeToHotbox()
    {
        // เปลี่ยนแปลงคุณสมบัติของ hitbox ให้เป็น hotbox
        hitbox.isTrigger = true; // ตัวอย่างการเปลี่ยนแปลง (ทำให้ Collider เป็น trigger)
        // คุณสามารถเพิ่มการเปลี่ยนแปลงอื่นๆ ได้ตามต้องการ
    }

    private void RevertToHitbox()
    {
        // เปลี่ยนแปลงคุณสมบัติกลับเป็น hitbox เดิม
        hitbox.isTrigger = false; // เปลี่ยน Collider กลับมาเป็น hitbox เดิม
        // คุณสามารถเพิ่มการเปลี่ยนแปลงอื่นๆ ได้ตามต้องการ
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isHot && other.CompareTag("Enemie")) // ตรวจสอบว่าชนกับศัตรูหรือไม่
        {
            // โค้ดสำหรับการโจมตีศัตรู
            Debug.Log("Attacked enemy: " + other.name);
        }
    }
}
