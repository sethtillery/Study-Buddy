using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTimer: MonoBehaviour
{
    public float timeValue = 15;
    public Text timerText;
    public bool startTime = false;

    private void Start()
    {
        DisplayTime(timeValue * 60);
        timeValue *= 60;
    }

    void Update()
    {
        if(startTime)
        {
            if (timeValue > 0)
            {
               // timeValue *= 60;
              timeValue -= Time.deltaTime;
                //timeValue /= 60;
            }
            else
            {
             timeValue = 0;
            }

            DisplayTime(timeValue);

        }
    }

   public void DisplayTime(float timeToDisplay)
   {
        
    if (timeToDisplay < 0)
    {
      timeToDisplay = 0;
    }

    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);
   // float milliseconds = timeToDisplay % 1 * 1000;

    timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

   }
}