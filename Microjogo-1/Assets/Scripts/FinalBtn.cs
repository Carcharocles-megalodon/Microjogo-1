using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FinalBtn : MonoBehaviour
{
    private Button button;
    private Choices choices;
    private int index;
    
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeEpilogue);
    }
    

    private void ChangeEpilogue()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("End Screen");
    }
}
