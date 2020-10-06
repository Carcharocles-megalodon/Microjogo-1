using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public struct Line
{
    public Character character;

    [TextArea(3, 10)] public string text;
}




[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue")]
public class DialogueScriptable : ScriptableObject
{
    public Character speakerLeft;
    public Character speakerRight;
    public Line[] lines;
}
