using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FinalBtn : MonoBehaviour
{
    private Button button;
    private Choices choices;
    private int index;
    
    
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeToEpilogue);
    }
    private void ChangeToEpilogue()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("End Screen");
    }
}
