using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreen : MonoBehaviour
{
   public GameObject todoList;
   public GameObject timer; 
   public GameObject homeScreen; 



 public void GotodoList()
 {
      homeScreen.gameObject.SetActive(false);
      todoList.gameObject.SetActive(true);
 }

 public void GoToTimer()
 {
      homeScreen.gameObject.SetActive(false);
      timer.gameObject.SetActive(true);

 }


 public void Quit()
 {
    Application.Quit();
 }

}
