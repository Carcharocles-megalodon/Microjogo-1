using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    

    [SerializeField] private DialogueScriptable dialogue;
    private Image image;
    


    public void Start()
    {
        image = gameObject.GetComponent<Image>();
        gameObject.AddComponent<CanvasGroup>();
        
    }

    public void TriggerDialogue()
    {
       FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
       gameObject.GetComponent<CanvasGroup>().alpha = 0f;
    }

    public void TurnOn()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 255f;
    }

    public void ChangeNPC(Sprite image, DialogueScriptable dialogue)
    {
        this.image.sprite = image;
        this.dialogue = dialogue;
    }
}
