using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookfollow: MonoBehaviour
{
    void Update()
    {
        // �Ѻ���˹觢ͧ���ͧ
        Camera mainCamera = Camera.main;

// ������ѵ���ѹ˹������ҡ��ͧ
if (mainCamera != null)
{
    Vector3 direction = mainCamera.transform.position - transform.position;
    direction.x = direction.z = 0.0f; // ��ͤ᡹ X ��� Z
    transform.LookAt(mainCamera.transform.position - direction);
    transform.Rotate(0, 180, 0); // ��Ѻ��ع���˹������ҡ��ͧ�١��ͧ
}
    }
}
