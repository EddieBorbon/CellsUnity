using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showText : MonoBehaviour
{
    public GameObject canvasObject;

    void OnMouseDown()
    {
        canvasObject.SetActive(!canvasObject.activeSelf);
    }
}
