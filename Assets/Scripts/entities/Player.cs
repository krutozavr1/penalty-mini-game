using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public static Player instance;
    float str = 0;
    bool playerTouchedScreen = false, canKick = true;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if((Input.touches.Length > 0) && (canKick))//when player touches screen
        {
            playerTouchedScreen = true;
            ChangeDirictionOfKick();
            StartStrengthScaling();      
        }
        else if(playerTouchedScreen)//when player releases finger
        {
            playerTouchedScreen = false;
            KickBall();
        }
    }

    private void ChangeDirictionOfKick()
    {
        if (Mathf.Abs(Input.GetTouch(0).deltaPosition.x) > .5f)
        {
            float deltaTouchPos = Input.GetTouch(0).deltaPosition.x / 100;
            Arrow.instance.ChangeDirection(deltaTouchPos);
        }
    }

    private void StartStrengthScaling()
    {
        str = (str + .02f) % 1;
        Arrow.instance.SetColor(str);
    }

    private void KickBall()
    {
        Ball.instance.SetVelocity(Arrow.instance.transform.up, str);
        GameManager.instance.ballWasKicked = true;
        canKick = false;
        GateKeeper.instance.TryCatchBall();
    }

    public void ResetAll()
    {
        canKick = false;
        StartCoroutine(Reset());
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(.5f);
        canKick = true;
        str = 0;
    }
}
