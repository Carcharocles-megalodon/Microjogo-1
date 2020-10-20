using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
   public int index;
   private Button button; 
   private Choices choice;
   private Button[] otherButtons;


   
   void Start()
   {
      button = GetComponent<Button>();
      button.onClick.AddListener(ChangeScene);
      button.onClick.AddListener(ChangeNPC);
      button.onClick.AddListener(DestroyButtons);
   }

   public void InformationPassing(Choices choice, int index, Button buttons)
   {
      otherButtons = new Button[choice.choices.Length];
      otherButtons[index] = buttons;
      this.choice = choice;
      this.index = index;
   }

   private void ChangeScene()
   {
      FindObjectOfType<SceneManager>().SceneChange(choice.choices[index].backgroundImage);
   }

   private void ChangeNPC()
   {
      FindObjectOfType<NPC>().TurnOn();
      FindObjectOfType<NPC>().ChangeNPC(choice.choices[index].npc.npcImage, choice.choices[index].npc.dialogue);
   }

   private void DestroyButtons()
   {
      FindObjectOfType<DialogueManager>().DestroyButtons();
   }

   
}
