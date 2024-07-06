using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Knockback : MonoBehaviour
{
    public float knockbackForce = 10f; // �ç�����㹡�� knockback
    public float knockbackDuration = 0.2f; // �������ҷ�� knockback ���Դ���
    public string enemyTag = "Enemie"; // Tag �ͧ�ѵ��

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

