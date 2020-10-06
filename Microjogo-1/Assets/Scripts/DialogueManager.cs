
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Queue<string> sentences;
   
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(DialogueScriptable dialogue)
    {
        
        nameText.text = dialogue.lines[].character.name;
        
        sentences.Clear();

        foreach (string sentence in dialogue.lines[].text)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }

    public void EndDialogue()
    {
        Debug.Log("End of conversation");
    }
}
