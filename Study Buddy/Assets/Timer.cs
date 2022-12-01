using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerValue = 90;
    public Text timerText;

    void Update()
    {
        if (timerValue > 0)
     {    
        timerValue -= Time.deltaTime;
     }
     else 
     {
        timerValue = 0;
     }
        DisplayTime(timerValue);
    }
    void DisplayTimer(float timeToDisplay)
{
    if (timeToDisplay < 0)
    {
        timeTodisplay = 0;
    }

    float minutes = Mathf.floorToInt(timeToDisplay / 60);
    float second =  Mathf.FloorToInt(timeToDisplay % 60);

    timerText.text = string.Format("{0:00}:{1:00}"), minutes, seconds;
}
}