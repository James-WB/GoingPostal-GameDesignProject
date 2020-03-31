using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        // Level 2??
        SceneManager.LoadScene("Start");
        Debug.Log("Level 2 loaded.");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
        Debug.Log("Tutorial level loaded.");
    }

    public void StartLevel1()
    {
        // Scene is missing in unity build settings
        // SceneManager.LoadScene("Level 1");
        // Debug.Log("Level 1 loaded.");
    }

    public void StartLevel3()
    {
        // SceneManager.LoadScene("Level 3");
        // Debug.Log("Level 3 loaded.");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
