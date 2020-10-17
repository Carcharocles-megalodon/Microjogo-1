using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
   [SerializeField] private Sprite backgroundImage;

   public void SceneChange(Sprite backgroundImage, GameObject newEvent)
   {
      this.backgroundImage = backgroundImage;
      newEvent.SetActive(true);
   }
   
}
 
