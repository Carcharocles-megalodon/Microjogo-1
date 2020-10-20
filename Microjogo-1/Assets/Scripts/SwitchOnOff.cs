using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchOnOff : MonoBehaviour
{
   private Button btn;
   public void Start()
   {
      gameObject.AddComponent<CanvasGroup>();
      btn = gameObject.GetComponentInChildren<Button>();
      btn.interactable = false;
   }

   public void TurnOn()
   {
      btn.interactable = true;
      gameObject.GetComponent<CanvasGroup>().alpha = 255f;
   }
   public void TurnOff()
   {
      btn.interactable = false;
      gameObject.GetComponent<CanvasGroup>().alpha = 0f;
   }
}
