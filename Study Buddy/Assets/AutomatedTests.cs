using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomatedTests : MonoBehaviour
{
    HomePageManager homePage;
    addTask addTask;
    DestroyTask destroyTask;
    TaskOptions taskOptions;
    TimerManager timerManager;

    // Start is called before the first frame update
    void Start()
    {
        homePage = GetComponent<HomePageManager>();
        addTask = GetComponent<addTask>();
        addTask.automated = true;
        taskOptions = GetComponent<TaskOptions>();
        timerManager = GetComponent<TimerManager>();
        timerManager.automated = true;
    }

    public void startAutomate()
    {
        StartCoroutine(Tests());
    }

    IEnumerator Tests()
    {
        yield return new WaitForSeconds(5);
        homePage.goToTaskScreen();
        yield return new WaitForSeconds(5);
        addTask.setTask();
        yield return new WaitForSeconds(5);
        addTask.newTask();
        destroyTask = GameObject.Find("Task Button(Clone)").GetComponent<DestroyTask>();
        yield return new WaitForSeconds(5);
        destroyTask.Options();
        yield return new WaitForSeconds(5);
        taskOptions.GoToTimer();
        yield return new WaitForSeconds(5);
        timerManager.StartTimer();
        yield return new WaitForSeconds(10);
        timerManager.PauseTimer();
        yield return new WaitForSeconds(5);
        timerManager.SetTimer();
        yield return new WaitForSeconds(5);
        timerManager.newTimeAmount();
        yield return new WaitForSeconds(5);
        timerManager.StartTimer();
        yield return new WaitForSeconds(10);
        homePage.goToHomeFromTimer();
        yield return new WaitForSeconds(5);
        homePage.goToTaskScreen();
        yield return new WaitForSeconds(5);
        destroyTask.Options();
        yield return new WaitForSeconds(5);
        taskOptions.completeTask();
        yield return new WaitForSeconds(5);
        destroyTask.Options();
        yield return new WaitForSeconds(5);
        taskOptions.deleteTask();
        yield return new WaitForSeconds(5);
        homePage.goToHomeFromTask();

    }
}
