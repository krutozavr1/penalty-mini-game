using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionChanger : MonoBehaviour
{
    int width, height;
    public void SetNewResolutionWidth(int width)
    {
        this.width = width;
    }
    public void SetNewResolutionHeight(int height)
    {
        this.height = height;

    }

    public void ChangeResolution()
    {
        Screen.SetResolution(width, height, true, 0);
        Camera.main.aspect = width / height;
        print(Screen.width + " " + Screen.height );
    }
}
