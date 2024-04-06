using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inspired by https://github.com/Brackeys/Dialogue-System

namespace Dialogue
{
public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
}