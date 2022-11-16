using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerfeature : MonoBehaviour
{
   {
    public float timeLeft = 30;
    public bool RunningTimer = false;
    public Text timeText;
    private void Start()
    {

        runningTimer = true;
    }
    void Update()
    {
        if (runningTimer)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                DisplayTime(timeLeft);
            }
            else
            {
                Debug.Log("Your time is out!!!");
                timeLeft = 0;
                RunningTimer = false;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}