using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskOptions : MonoBehaviour
{
    public bool moveTasks = false;
    public addTask addTask;
   // public List<Button> buttons;
    public GameObject optionsScreen;
    public DestroyTask ds;
    bool foundSelectedButton = false;
    public GameObject[] allChildren;
    public GameObject TaskScreen;
    public GameObject TimerScreen;
    public NewTimer timer;

    public void completeTask()
    {
        allChildren = new GameObject[GameObject.Find("TaskButtons").transform.childCount];

        int k = 0;
        foreach (Transform child in GameObject.Find("TaskButtons").transform)
        {
            allChildren[k] = child.gameObject;
            k += 1;
        }

        for (int i = 0; i < allChildren.Length; i++)
        {
            if (allChildren[i].gameObject.tag == "Selected Button")
            {
                allChildren[i].GetComponent<Image>().color = Color.green;
                Debug.Log("Found Selected Button");
                allChildren[i].tag = "Button";
            }
        }
        optionsScreen.SetActive(false);
    }

    public void deleteTask()
    {
        
        allChildren = new GameObject[GameObject.Find("TaskButtons").transform.childCount];

        int k = 0;
        foreach (Transform child in GameObject.Find("TaskButtons").transform)
        {
            allChildren[k] = child.gameObject;
            k += 1;
        }
        
        for (int i = 0; i < allChildren.Length; i++)
        {
            if(allChildren[i].gameObject.tag == "Selected Button")
            {
                foundSelectedButton = true;
                Destroy(allChildren[i].gameObject);
                Debug.Log("Found Selected Button");
            }
            
            if(foundSelectedButton)
              allChildren[i].transform.position = new Vector3(allChildren[i].transform.position.x, allChildren[i].transform.position.y + 180, allChildren[i].transform.position.z);                                     
        }
        foundSelectedButton = false;
      
        moveTasks = true;

        addTask.startPosition.position = new Vector3(addTask.startPosition.position.x, addTask.startPosition.position.y + 180, addTask.startPosition.position.z);
        addTask.addTasksButton.transform.position = new Vector3(addTask.addTasksButton.transform.position.x, addTask.addTasksButton.transform.position.y + 180, addTask.addTasksButton.transform.position.z);

        addTask.taskCounter--;
        optionsScreen.SetActive(false);
    }

    public void GoToTimer()
    {
        allChildren = new GameObject[GameObject.Find("TaskButtons").transform.childCount];

        int k = 0;
        foreach (Transform child in GameObject.Find("TaskButtons").transform)
        {
            allChildren[k] = child.gameObject;
            k += 1;
        }

        for (int i = 0; i < allChildren.Length; i++)
        {
            if (allChildren[i].gameObject.tag == "Selected Button")
            {
                // timer.timeValue = allChildren[i].
                Debug.Log("Found Selected Button");
                allChildren[i].tag = "Button";
            }
        }

        TaskScreen.SetActive(false);
        TimerScreen.SetActive(true);

        timer = GameObject.Find("timertext").GetComponent<NewTimer>();
        timer.timeValue = addTask.tasktime;

    }
}
