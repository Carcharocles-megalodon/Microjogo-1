
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Collections;
using System.ComponentModel;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public Button prefab;
    public Button finalChoiceBtn;
    public TextMeshProUGUI dialogueText;
    private DialogueScriptable dialogue;
    private Choices choice;
    private Button[] choiceButtons;
    [SerializeField] private GameObject panel;
    
    
    private int index;
   
    void Start()
    {
        index = 1;
        
    }

    public void StartDialogue(DialogueScriptable dialogue)
    {
        FindObjectOfType<SwitchOnOff>().TurnOn();
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
                Debug.Log("Presenting choices now.");
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
    }

    public void PresentChoices()
    {
        dialogueText.text = choice.question;
        
    }

    public void SpawnButtons()
    {
        for (int i = 0; i < choice.choices.Length; i++)
        {
            if (choice.choices[i].final == true)
            {
                choiceButtons[i] = Instantiate(finalChoiceBtn, panel.gameObject.transform);
                choiceButtons[i].gameObject.AddComponent<FinalBtn>();
            }
            else
            {
                choiceButtons[i] = Instantiate(prefab, panel.gameObject.transform); // cria o botão
                choiceButtons[i].gameObject.AddComponent<ButtonScript>(); //atribui o script que atribui a função
                choiceButtons[i].GetComponent<ButtonScript>().InformationPassing(choice,i);// passa a informaçao para a funçao poder ser atuada
            }
            
            
            
            
            choiceButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = choice.choices[i].choice; // muda o texto do botão
        }
    }
    
    
}
