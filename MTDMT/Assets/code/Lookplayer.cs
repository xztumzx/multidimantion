using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookplayer : MonoBehaviour
{
    public Transform Player; // ������纵��˹觢ͧ player
    private SpriteRenderer spriteRenderer; // ������� SpriteRenderer �ͧ NPC

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // �֧ SpriteRenderer �ҡ NPC
    }

    void Update()
    {
        FlipSpriteBasedOnXPosition();
    }

    void FlipSpriteBasedOnXPosition()
    {
        if (Player.position.x > transform.position.x)
        {
            // flip horizontal sprite
            spriteRenderer.flipX = true;
        }
        else
        {
            // �׹��� sprite ���������͹���
            spriteRenderer.flipX = false;
        }

    }
}
