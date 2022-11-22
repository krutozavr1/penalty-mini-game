using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] Arrow arrow;
    [SerializeField] Ball ball;
    float dir;
    float str = 0;
    bool playerTouchedScreen = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.touches.Length > 0)
        {
            playerTouchedScreen = true;
            GetDirictionOfKick();
            StartStrengthScaling();
        }
        else if(playerTouchedScreen)
        {
            playerTouchedScreen = false;
            KickBall();
        }

    }

    private void GetDirictionOfKick()
    {
        if (Mathf.Abs(Input.GetTouch(0).deltaPosition.x) > .5f)
        {
            dir = Input.GetTouch(0).deltaPosition.x / 100;
            arrow.SetDirection(dir);

        }
    }

    private void StartStrengthScaling()
    {
        str = (str + .02f) % 1;
        arrow.SetColor(str);
    }

    private void KickBall()
    {
        ball.SetVelocity(arrow.transform.up, str);
    }
}
