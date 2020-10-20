using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
   [SerializeField] private Image backgroundImage;
   public static TextMeshProUGUI epilogue;
   

   public void SceneChange(Sprite backgroundImage)
   {
      this.backgroundImage.sprite = backgroundImage;
   }

   public void PlayGame()
   {
      UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
   }

   public void Restart()
   {
      UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
   }

   public static void ChangeEpilogue()
   {
      string s = Epilogue.giveString();
      epilogue.text = s;
   }

   public void QuitGame()
   {
      Application.Quit();
   }
   
}
 
