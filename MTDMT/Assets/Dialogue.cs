using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue: MonoBehaviour
{
    [SerializeField]
    private GameObject dialogueCanvas;

    [SerializeField]
    private TMP_Text speakerText;

    [SerializeField]
    private TMP_Text dialogueText;

    [SerializeField]
    private Image portraitImage;

    //Dialogue Content
    [SerializeField]
    private string[] speaker;

    [SerializeField]
    [TextArea]
    private string[] dialogueWords;

    [SerializeField]
    private Sprite[] portrait;

    private bool dialogueActivated;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && dialogueActivated == true)
        {
            dialogueCanvas.SetActive(true);
            speakerText.text = speaker[0];
            dialogueText.text = dialogueWords[0];
            portraitImage.sprite = portrait[0];
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dialogueActivated = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogueActivated = false;
        dialogueCanvas.SetActive(false);
    }
}
