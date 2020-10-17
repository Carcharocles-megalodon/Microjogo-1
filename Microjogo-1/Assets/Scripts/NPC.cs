using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private DialogueScriptable dialogue;

    public void TriggerDialogue()
    {
       FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
       gameObject.SetActive(false);
    }
}
