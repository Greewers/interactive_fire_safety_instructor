using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameLoader : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("FinalScene");
    }
}
