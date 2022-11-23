using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameChooser : MonoBehaviour
{

    public void LoadMiniGame(string name)
    {
        SceneManager.LoadScene(name);
    }
}
