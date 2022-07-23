using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    public InputField Username;
    
    private void Start()
    {
       
    }

    public void StartNew()
    {
        MainManager.Instance.SaveUsername();
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        MainManager.Instance.SaveUsername();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
    public void UpdateUsername()
    {
        MainManager.Instance.Username = Username.text;
        Debug.Log("1 " + MainManager.Instance.Username);
    }
}
