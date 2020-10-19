using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
   [SerializeField] private Image backgroundImage;
   

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
      UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
   }

   public void QuitGame()
   {
      Application.Quit();
   }
   
}
 
