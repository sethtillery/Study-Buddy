using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public NewTimer timer;
    public float newTimerAmount;
    public InputField inputTime;
    public GameObject setTimerScreen;

    private void Start()
    {
       // timer = GameObject.Find("timertext").GetComponent<NewTimer>();
    }

    public void StartTimer()
    {
        timer = GameObject.Find("timertext").GetComponent<NewTimer>();
        timer.startTime = true;
    }

    public void PauseTimer()
    {
        timer.startTime = false;
    }

    public void SetTimer()
    {
        setTimerScreen.SetActive(true);
    }

    public void newTimeAmount()
    {
        newTimerAmount = float.Parse(inputTime.text);
        timer.timeValue = newTimerAmount;
        timer.DisplayTime(timer.timeValue * 60);
        setTimerScreen.SetActive(false);
    }
}
