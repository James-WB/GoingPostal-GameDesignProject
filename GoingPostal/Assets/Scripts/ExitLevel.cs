﻿using System.Collections;
    public GameObject startMenu;
    public GameObject LevelMenu;
            SceneManager.LoadScene("Menu");
            startMenu = GameObject.FindWithTag("StartMenu");
            Debug.Log(startMenu);
            startMenu.SetActive(false);
        }