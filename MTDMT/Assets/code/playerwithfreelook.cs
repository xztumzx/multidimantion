using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwithfreelook : MonoBehaviour
{
    public float moveSpeed = 5f;  // ��������㹡������͹���
    public float rotateSpeed = 100f;  // ��������㹡����ع
    public float runSpeedMultiplier = 2f;  // ��Ǥٳ����������������

    private Rigidbody rb;
    private Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;  // �ҡ�� MainCamera ��������觹�� �ҡ���������˹� mainCamera �ͧ
    }

    void FixedUpdate()
    {
        // �Ѻ�Թ�ص�ҡ������
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        bool isRunning = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);  // ��Ǩ�ͺ��ҡ� Shift �������

        // �ҷ�ȷҧ�ͧ���ͧ
        Vector3 cameraForward = mainCamera.transform.forward;
        Vector3 cameraRight = mainCamera.transform.right;
        cameraForward.y = 0f;  // ���ʹ�᡹ Y 㹡����ع������ͧ
        cameraRight.y = 0f;  // ���ʹ�᡹ Y 㹡����ع������ͧ

        // �ӹǳ��ȷҧ�������͹���ͧ����Ф�
        Vector3 movement = Vector3.zero;
        movement = moveVertical * cameraForward.normalized + moveHorizontal * cameraRight.normalized;

        // �ӹǳ�����ع������ͧ
        if (movement != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement);
            rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, newRotation, rotateSpeed * Time.fixedDeltaTime));
        }
        
        // ��Ǩ�ͺ�������������
        if (isRunning)
        {
            movement *= runSpeedMultiplier;  // ����������������͡� Shift
        }

        // �ӹǳ�����ع������ͧ
        if (movement != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement);
            rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, newRotation, rotateSpeed * Time.fixedDeltaTime));
        }
        // �ӹǳ�������͹��������䢵��˹觢ͧ����Ф�
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
