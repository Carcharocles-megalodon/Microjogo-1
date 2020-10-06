using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Choice",menuName = "Choice")]
public class Choices : ScriptableObject
{
    public string question;
    public string[] choices;
}
