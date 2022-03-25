using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    private Goal[] goals;
    private int notClearNum;

    // Start is called before the first frame update
    void Start()
    {
        goals = FindObjectsOfType<Goal>();
        notClearNum = goals.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckEveryBoyInGoal()
    {
        for(int i = 0; i < goals.Length; i++)
        {
            if(goals[i].IsBoyHere() == false)
            {
                return;
            }
        }

        ClearGame();
    }

    private void ClearGame()
    {
        BoyManager[] BoyManagers = FindObjectsOfType<BoyManager>();

        for(int i = 0; i < BoyManagers.Length; i++)
        {
            BoyManagers[i].TurnOffCollider();
        }
    }
}
