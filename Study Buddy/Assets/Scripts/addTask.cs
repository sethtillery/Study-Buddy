using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addTask : MonoBehaviour
{
    public GameObject taskPrefab;
    public Transform startPosition;
    public GameObject addTasksButton;
    public int taskCounter = 0;
    public Text taskName;
    public Text taskDueDate;
    public InputField inputTaskName;
    public InputField inputTaskDueDate;
    public GameObject inputScreen;

    
    public void setTask()
    {
        if (taskCounter < 10)
        {
            inputScreen.gameObject.SetActive(true);
        }
    }

    public void newTask()
    {
        if(taskCounter < 10)
        {
            taskName.text = inputTaskName.text;
            taskDueDate.text = inputTaskDueDate.text;

            GameObject newTask = Instantiate(taskPrefab, startPosition.position, transform.rotation) as GameObject;
            newTask.transform.SetParent(GameObject.Find("TaskButtons").transform);
            inputScreen.gameObject.SetActive(false);
            newTask.transform.GetChild(0).GetComponent<Text>().text = taskName.text;
            newTask.transform.GetChild(1).GetComponent<Text>().text = taskDueDate.text;

            inputTaskName.text = "";
            inputTaskDueDate.text = "";


            startPosition.position = new Vector3(startPosition.position.x, startPosition.position.y - 180, startPosition.position.z);
            addTasksButton.transform.position = new Vector3(addTasksButton.transform.position.x,  addTasksButton.transform.position.y - 180, addTasksButton.transform.position.z);
            taskCounter++;
        }

        if(taskCounter == 9)
        {
            addTasksButton.gameObject.SetActive(false);
        }
    }
}
