using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI; // reference to your game over UI panel
    
    public void GameOver()
    {
        gameOverUI.SetActive(true);
        gameOverUI.GetComponent<Animator>().SetTrigger("gameover trigger");
        Time.timeScale = 0f; // pause the game
    
    }

     public void RetryGame()
    {
        Time.timeScale = 1f; // unpasue the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
