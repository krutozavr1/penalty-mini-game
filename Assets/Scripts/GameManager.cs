using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public bool ballWasKicked  = false;
    [SerializeField] GameObject resetButton;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if(ballWasKicked)
        {
            resetButton.SetActive(true);
        }
    }

    public void ResetScene()
    {
        Ball.instance.ResetPosition();
        Player.instance.ResetAll();
        GateKeeper.instance.ResetPosition();
        ballWasKicked = false;
        resetButton.SetActive(false);
    }
}
