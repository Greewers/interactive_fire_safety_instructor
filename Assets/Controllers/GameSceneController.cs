using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    public Sprite[] floor1sprites;
    public Sprite[] floor2sprites;
    public Sprite[] floor3sprites;
    public Sprite[] floor4sprites;
    public Sprite[] laddersprites;

    public static int Timer;

    public List<EntryPointsMap> entryPoints;
    public void Start()

    {
        Timer = 0;
        ShowFirstImage(MapSceneController.entryPointID);
    }

    public void ShowFirstImage(string id)
    {
        foreach (EntryPointsMap map in entryPoints) 
        { 
            if (map.ID == id)
            {
                map.gameObject.SetActive(true);
            }
        }
    }

}

[System.Serializable]
public class EntryPointsMap
{
    public string ID;
    public GameObject gameObject;

}