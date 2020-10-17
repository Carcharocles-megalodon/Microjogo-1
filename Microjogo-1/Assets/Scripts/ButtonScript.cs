using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
   public int index;
   private Button button;
   private Choices choice;


   
   void Start()
   {
      button = button.GetComponent<Button>();
      button.onClick.AddListener(ChangeScene);
   }

   public void InformationPassing(Choices choice, int index)
   {
      this.choice = choice;
      this.index = index;
   }

   private void ChangeScene()
   {
      //FindObjectOfType<SceneManager>().SceneChange(choice.choices[index].backgroundImage,choice.choices[index].nextNPC);
   }
}
