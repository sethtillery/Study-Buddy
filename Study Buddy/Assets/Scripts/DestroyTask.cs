using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyTask : MonoBehaviour
{
    public TaskOptions taskOptions;

    public void Start()
    {
            taskOptions = GameObject.Find("App Manager").GetComponent<TaskOptions>();            
    }

    
    public void SelectedButton()
    {
        //gameObject.tag = "Selected Button";
        Debug.Log("Clicked");
    }

    public void Options()
    {
        taskOptions.optionsScreen.SetActive(true);

        gameObject.tag = "Selected Button";
    }
    public void FixedUpdate()
    {
        if(taskOptions.moveTasks)
        {
            taskOptions.moveTasks = false;
           // Destroy(GameObject.FindGameObjectWithTag("Selected Button"));
        }      
    }    
}
