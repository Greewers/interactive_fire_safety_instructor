using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void InstructionSceneLoader()
    {
        SceneManager.LoadScene("instructionScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
