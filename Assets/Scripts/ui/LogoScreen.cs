using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoScreen : MonoBehaviour
{
    [SerializeField]GameObject screen;
    private void HideLogoScreen()
    {
        screen.SetActive(false);
    }
}
