using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Inspired by https://github.com/Brackeys/Dialogue-System

namespace Dialogue
{
public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    public void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        nameText.text = dialogue.name;
        sentences = new Queue<string>(dialogue.sentences);
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        StopAllCoroutines();
        var sentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = string.Empty;
        foreach (var c in sentence.ToCharArray())
        {
            dialogueText.text += c;
            yield return null;
        }
    }

    private void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }
}
}
