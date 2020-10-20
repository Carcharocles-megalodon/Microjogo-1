using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class Epilogue : MonoBehaviour
{
  private static string epilogue;
  public TextMeshProUGUI epilogueText;


  public void Update()
  {
    ChangeEpilogue();
  }

  public void ChangeEpilogue()
  {
    epilogueText.text = giveString();
  }

  public static void fillString(string epilogue_)
  {
    epilogue = epilogue_;
  }

  public static string giveString()
  {
    return epilogue;
  }
}
