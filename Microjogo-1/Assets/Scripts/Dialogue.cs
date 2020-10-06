using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

[System.Serializable]
public class Dialogue
{
    public Choices choice;
    public string name;
    [TextArea(3,10)]
    public string[] sentences;
    
    void Update()
    {
        sentences[sentences.Length - 1] = choice.question;
    }
}
