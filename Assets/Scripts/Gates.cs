using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ball"))
        {
            ScoreGoal();
        }
    }

    private void ScoreGoal()
    {
        print("goal");
    }
}
