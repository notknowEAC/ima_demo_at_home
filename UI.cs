using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIhandler : MonoBehaviour
{
    public GameObject LevelDialog;
    public Text LevelStatus;
    public Text scoreText;

    public static  UIhandler instance;

    void Awake()
    {
       if (instance == null) 
            instance = this;
    }

    public void ShowLevelDialog(string status,string scores)
    {
        LevelDialog.SetActive(true);
        LevelStatus.text = status;
        scoreText.text = scores;
    }
}
