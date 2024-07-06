using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotbox : MonoBehaviour
{
    public Collider hitbox; // ���������Ѻ�� Collider �ͧ hitbox
    public float hotboxDuration = 1.0f; // �������ҷ����� hotbox
    public bool isHot = false; // ��Ǩ�ͺ��һѨ�غѹ�� hotbox �������

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
        // ����¹�ŧ�س���ѵԢͧ hitbox ����� hotbox
        hitbox.isTrigger = true; // ������ҧ�������¹�ŧ (����� Collider �� trigger)
        // �س����ö�����������¹�ŧ���� ������ͧ���
    }

    private void RevertToHitbox()
    {
        // ����¹�ŧ�س���ѵԡ�Ѻ�� hitbox ���
        hitbox.isTrigger = false; // ����¹ Collider ��Ѻ���� hitbox ���
        // �س����ö�����������¹�ŧ���� ������ͧ���
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isHot && other.CompareTag("Enemie")) // ��Ǩ�ͺ��Ҫ��Ѻ�ѵ���������
        {
            // ������Ѻ��������ѵ��
            Debug.Log("Attacked enemy: " + other.name);
        }
    }
}
