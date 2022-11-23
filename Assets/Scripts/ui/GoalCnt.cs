using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalCnt : MonoBehaviour
{
    public static GoalCnt instance;
    TextMeshProUGUI tmp;
    int goalCnt = 0;

    void Awake()
    {
        tmp = GetComponent<TextMeshProUGUI>();
        instance = this;
    }

    public void AddGoal()
    {
        goalCnt++;
        tmp.text = "Goals: " + goalCnt.ToString();
    }
}
