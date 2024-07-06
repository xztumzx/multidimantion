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
        // หาอ็อบเจกต์ที่มี Animator อื่นๆ ในซีน
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
        if (otherAnimator.GetBool("hit1")) // ตัวอย่างการตรวจสอบการกดปุ่ม Space เพื่อโจมตี
        {
            hotboxScript.ActivateHotbox();
        }
    }
}
