using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class spawnhotbox : MonoBehaviour
{
    public hotbox hotboxScript;
    private Animator otherAnimator;

    void Start()
    {
        // ����ͺਡ������ Animator ���� 㹫չ
        GameObject otherObject = GameObject.Find("fadale");

        if (otherObject != null)
        {
            otherAnimator = otherObject.GetComponent<Animator>();
        }
        else
        {
            Debug.LogError("Cannot find 'OtherObject' in the scene.");
        }
    }
    private void Update()
    {
        if (otherAnimator.GetBool("hit1")) // ������ҧ��õ�Ǩ�ͺ��á����� Space ��������
        {
            hotboxScript.ActivateHotbox();
        }
    }
}
