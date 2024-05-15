using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public List<Arrow> Arrows;
    public int time = 5;

    public void AddTimer() 
    {
        GameSceneController.Timer += time;
        Debug.Log(GameSceneController.Timer);
    }
}
