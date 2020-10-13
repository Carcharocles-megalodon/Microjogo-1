﻿
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public DialogueScriptable dialogue;
    public Choices choice;
    
    public int index;
   
    void Start()
    {
        index = 1;
    }

    public void StartDialogue(DialogueScriptable dialogue)
    {
        this.dialogue = dialogue;
        nameText.text = this.dialogue.lines[0].character.name;
        dialogueText.text = dialogue.lines[0].text;
        this.choice = dialogue.choice;
    }

    

    public void DisplayNextSentence()
    {
        if (index == dialogue.lines.Length)
        {
            EndDialogue();
            return;
        }
        dialogueText.text = dialogue.lines[index].text;
        nameText.text = dialogue.lines[index].character.name;
        index++;
    }

    public void EndDialogue()
    {
        PresentChoices();
        Debug.Log("Presenting choices now.");
    }

    public void PresentChoices()
    {
        dialogueText.text = choice.question;
    }

    public void EndConversation()
    {
        //FindObjectOfType(TextMeshPro);
    }
}
