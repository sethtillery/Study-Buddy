using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePageManager : MonoBehaviour
{
    public GameObject TaskScreen;
    public GameObject TimerScreen;
    public GameObject HomeScreen;

    public void goToTaskScreen()
    {
        HomeScreen.SetActive(false);
        TaskScreen.SetActive(true);

        GameObject taskOptions = GameObject.Find("Task Options Screen");
        GameObject addTask = GameObject.Find("Input Screen");
        if(taskOptions)
            taskOptions.SetActive(false);

        if (addTask)
            addTask.SetActive(false);  
    }

    public void goToTimerScreen()
    {
        HomeScreen.SetActive(false);
        TimerScreen.SetActive(true);

        GameObject setTimer = GameObject.Find("Set Timer Screen");
        if (setTimer)
            setTimer.SetActive(false);       
    }

    public void goToHomeFromTimer()
    {
        TimerScreen.SetActive(false);
        HomeScreen.SetActive(true);
    }

    public void goToHomeFromTask()
    {
        TaskScreen.SetActive(false);
        HomeScreen.SetActive(true);
    }
}
