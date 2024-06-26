using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    public RectTransform pointer;

    void Update()
    {
        Vector2 movePos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(pointer.parent as RectTransform, Input.mousePosition, null, out movePos);
        pointer.localPosition = movePos;
    }
}
