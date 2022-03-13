/*Script for main menu buttons such as Play, Options and Exit. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
        {
            SceneManager.LoadScene("Bedroom");
        }

    public void ExitGame()
        {
            Debug.Log("EXIT");
            Application.Quit();
        }

}
