using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneController : MonoBehaviour
{
    public TextMeshProUGUI Text;
    void Start()
    {
        Text.text = TimeSpan.FromSeconds(GameSceneController.Timer).ToString(@"mm\:ss");
    }

    public void MenuSceneLoader()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

}
