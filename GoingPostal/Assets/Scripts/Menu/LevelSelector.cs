using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector: MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Start");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

}
