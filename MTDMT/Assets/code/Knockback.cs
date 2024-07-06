using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Knockback : MonoBehaviour
{
    public float knockbackForce = 10f; // แรงที่ใช้ในการ knockback
    public float knockbackDuration = 0.2f; // ระยะเวลาที่ knockback จะเกิดขึ้น
    public string enemyTag = "Enemie"; // Tag ของศัตรู

    private Rigidbody rb;
    private bool isKnockbackActive = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(enemyTag) && !isKnockbackActive)
        {
            Vector3 knockbackDirection = (transform.position - collision.transform.position).normalized;
            StartCoroutine(ApplyKnockback(knockbackDirection));
        }
    }

    private IEnumerator ApplyKnockback(Vector3 direction)
    {
        isKnockbackActive = true;

        float timer = 0;
        while (timer < knockbackDuration)
        {
            rb.AddForce(direction * knockbackForce, ForceMode.Impulse);
            timer += Time.deltaTime;
            yield return null;
        }

        isKnockbackActive = false;
    }
} 

