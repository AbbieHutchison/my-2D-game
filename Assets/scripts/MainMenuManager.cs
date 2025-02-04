using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
   // function to load a scene based on the scene name

   public void LoadScene(string sceneName)
   {
    SceneManager.LoadScene(sceneName);
   }

   //function to quit the game
   public void QuitGame()
   {
    Application.Quit();
   }
}
