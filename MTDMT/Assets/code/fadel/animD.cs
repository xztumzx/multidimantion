using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animD : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipSpriteBasedOnXPosition();
    }

    void FlipSpriteBasedOnXPosition()
    {
        if (Input.GetKey(KeyCode.D))
        {
            // flip horizontal sprite
            spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            // คืนค่า sprite ให้เป็นเหมือนเดิม
            spriteRenderer.flipX = false;
        }

    }
}
