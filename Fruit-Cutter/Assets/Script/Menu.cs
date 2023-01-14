
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] private bool pause = false;
    public void exitGame()
    {
        Debug.Log("Namaste World");
        Application.Quit();
    }
    public void nextLevel()
    {
        Invoke("startLevel", .1f);

    }

    private void startLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void pauseGame()
    {
        if (pause) // if true then play
        {
            Time.timeScale = 1;
            pause = false;
        }
        else // pause the game
        {
            Time.timeScale = 0;
        }
    }

    public void resumeGame()
    {
        if (pause) // if pause 
        {
            Time.timeScale = 0;
            pause = true;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

}