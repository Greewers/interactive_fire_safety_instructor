using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InstructionController : MonoBehaviour
{
    public GameObject pageOne;
    public GameObject pageTwo;

    public void Start()
    {
        pageOne.SetActive(true);
        pageTwo.SetActive(false);
    }
    public void ShowPanel1()
    {
        pageTwo.SetActive(false);
        pageOne.SetActive(true);
    }

    public void ShowPanel2()
    {
        pageOne.SetActive(false);
        pageTwo.SetActive(true);
    }
    public void MainMenuSceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
