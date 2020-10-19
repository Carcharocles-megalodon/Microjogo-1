using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public struct Choice
{
    [TextArea(3,10)] public string choice;
    public Sprite backgroundImage;
    public NPCScriptable npc;
    public bool final;
    [TextArea(3,10)] public string epilogue;
}


[CreateAssetMenu(fileName = "New Choice",menuName = "Choice")]
public class Choices : ScriptableObject
{
    public string question;
    public Choice [] choices;
}
