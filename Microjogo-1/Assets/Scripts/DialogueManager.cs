
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public Button prefab;
    public TextMeshProUGUI dialogueText;
    private DialogueScriptable dialogue;
    private Choices choice;
    private Button[] choiceButtons;
    
    
    private int index;
   
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
        choiceButtons = new Button[choice.choices.Length];
    }

    

    public void DisplayNextSentence()
    {
        if (index == dialogue.lines.Length)
        {
            EndDialogue();
            if (dialogueText.text == choice.question)
            {
                FindObjectOfType<SwitchOnOff>().TurnOff();
                SpawnButtons();
                return;
            }
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

    public void SpawnButtons()
    {
        for (int i = 0; i < choice.choices.Length; i++)
        {
            choiceButtons[i] = Instantiate(prefab, new Vector2(0 + 800 * i, 0), Quaternion.identity);
            choiceButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = choice.choices[i];
        }
    }

    public void EndConversation()
    {
        
    }
}
