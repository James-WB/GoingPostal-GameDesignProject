using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.SceneManagement;public class ExitLevel : MonoBehaviour    {    public GameObject playerObj;
    public GameObject startMenu;
    public GameObject LevelMenu;    void Update()    {        if(Input.GetButtonDown("r") && playerObj){
            SceneManager.LoadScene("Menu");
            startMenu = GameObject.FindWithTag("StartMenu");
            Debug.Log(startMenu);
            startMenu.SetActive(false);
        }    }    void OnTriggerEnter2D(Collider2D collider){        if(collider.CompareTag("Player")){            playerObj = collider.gameObject;        }    }    void OnTriggerExit2D(Collider2D collider)    {        playerObj = null;    }                    }