using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Events")]
    public UnityEvent startDialogueEvent;
    public UnityEvent nextSentenceDialogueEvent;
    public UnityEvent endDialogueEvent;
}
