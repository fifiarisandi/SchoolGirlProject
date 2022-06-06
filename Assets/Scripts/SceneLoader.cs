using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;              //For loading new scene

public class SceneLoader : MonoBehaviour
{
   //For loading the new game scene
   public void LoadGame()
   {
       //Loads the next scene after the current active scene
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
       //sfxmanager.sfxInstance.Audio.PlayOneShot(sfxmanager.sfxInstance.click);
   }

   //For Quiting the Game
   public void QuitGame()
   {
      
       Application.Quit();
       //To see that Quit has been done in unity
       Debug.Log("QUIT!!!");
   }


}
