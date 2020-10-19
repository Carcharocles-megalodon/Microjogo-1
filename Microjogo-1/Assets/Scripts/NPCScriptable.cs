using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New NPC",menuName = "NPC")]
public class NPCScriptable : ScriptableObject
{
    public DialogueScriptable dialogue;
    public Sprite npcImage;
}
