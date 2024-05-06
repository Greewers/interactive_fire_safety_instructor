using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSceneController : MonoBehaviour
{
    [SerializeField] GameObject[] canvases;
    [SerializeField] GameObject[] cabinets;
    public int selectedCabinet;
    public int selectedFloor = 1;
    public void Start()
    {
        canvases[0].SetActive(true);
        canvases[1].SetActive(false);
        canvases[2].SetActive(false);
        canvases[3].SetActive(false);
    }
    public void CabinetChooser(int index)
    {
        selectedCabinet = index;
        Debug.Log(selectedFloor);
        Debug.Log(selectedCabinet);
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
