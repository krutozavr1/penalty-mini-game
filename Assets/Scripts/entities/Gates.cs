using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            ScoreGoal();
        }
    }

    private void ScoreGoal()
    {
        GoalCnt.instance.AddGoal();
    }
}
