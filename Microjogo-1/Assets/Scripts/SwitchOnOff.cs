using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOff : MonoBehaviour
{
   public void TurnOn()
   {
      gameObject.SetActive(true);
   }
   public void TurnOff()
   {
      gameObject.SetActive(false);
   }
}
