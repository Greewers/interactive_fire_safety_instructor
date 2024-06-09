using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSceneController : MonoBehaviour
{
    [SerializeField] GameObject[] canvases;

    public static int selectedFloor = 1;
    public static string entryPointID;

    public void Start()
    {
        canvases[0].SetActive(true);
        canvases[1].SetActive(false);
        canvases[2].SetActive(false);
        canvases[3].SetActive(false);
    }
    public void CabinetChooser(string id)
    {
        entryPointID = id;
        SceneManager.LoadScene("GameScene");
    }

    public void FloorChooser(int index)
    {
        for (int i = 0; i < canvases.Length; i++)
        {
            if (i == index)
            {
                canvases[i].SetActive(true);
                selectedFloor = i + 1;
            }
            else
            {
                canvases[i].SetActive(false);
            }
        }
    }

}
