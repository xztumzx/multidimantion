using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookplayer : MonoBehaviour
{
    public Transform Player; // ตัวแปรเก็บตำแหน่งของ player
    private SpriteRenderer spriteRenderer; // ตัวแปรเก็บ SpriteRenderer ของ NPC

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // ดึง SpriteRenderer จาก NPC
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
            // คืนค่า sprite ให้เป็นเหมือนเดิม
            spriteRenderer.flipX = false;
        }

    }
}
