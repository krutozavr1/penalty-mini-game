using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowButton : MonoBehaviour
{
    public void ShowOrHideWindow()
    {
        Time.timeScale = (Time.timeScale + 1) % 2;
        Player.instance.enabled = !Player.instance.enabled;
        gameObject.SetActive(!gameObject.active);

    }

}
