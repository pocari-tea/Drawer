using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Button : MonoBehaviour
{
    public void ClickStart()
    {
        SceneManager.LoadScene("Menu");
    }    
    
    public void ClickExit()
    {
        Application.Quit();
    }    
}
