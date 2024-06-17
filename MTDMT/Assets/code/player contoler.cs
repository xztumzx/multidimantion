using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontoler : MonoBehaviour
{
    public float speed = 5.0f; // ��������㹡���Թ�ͧ����Ф�

    private Rigidbody rb;
    private Transform mainCameraTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // ��Ҷ֧ Rigidbody �ͧ����Ф�
        mainCameraTransform = Camera.main.transform; // ��ҧ�ԧ�֧���ͧ��ѡ㹫չ
    }

    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // �ҷ�ȷҧ�������͹��ǵ����á�����
        Vector3 forward = mainCameraTransform.forward;
        Vector3 right = mainCameraTransform.right;

        // ������ȷҧ�������͹�����������йҺ (��ͤ᡹ Y)
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 movement = forward * moveVertical + right * moveHorizontal;

        if (movement.magnitude > 0)
        {
            // ��ع����Ф�����ѹ˹��仵����ȷҧ�������͹���
            transform.rotation = Quaternion.LookRotation(movement);

            // ����͹������Ф�
            rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
        }
    }
}
