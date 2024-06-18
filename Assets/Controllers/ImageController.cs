using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public Sprite[] floorImages; 
    private Image imageComponent;
    void Start()
    {
        imageComponent = GetComponent<Image>();
    }
    public void SetFloorImage(int floorIndex)
    {
        if (floorIndex >= 0 && floorIndex < floorImages.Length)
        {
            imageComponent.sprite = floorImages[floorIndex];
        }
        else
        {
            Debug.LogError("Floor index is out of range!");
        }
    }
}
