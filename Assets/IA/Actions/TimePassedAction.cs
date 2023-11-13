using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(A) TimePassed", menuName = "ScriptableObjects/Actions/TimePassedAction")]

public class TimePassedAction : Action
{
    private float currentTime;
    public float maxTime;

    

    public override bool Check(GameObject owner)
    {
        currentTime += Time.deltaTime;
        if (currentTime > maxTime)
        {
            currentTime = 0;
            return true;
        }
        return false;
    }
}
