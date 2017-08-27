//
//  LevelManager.cs
//  Brick Buster
//
//  Created on August 25, 2017 by Animesh Mishra
//  Copyright (c) 2017 Animesh Ltd
//  All Rights Reserved
//

using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public void LoadLevel(string name) {
        SceneManager.LoadScene(name);
    }

    public void Quit() {
        Application.Quit();
    }

    public void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            LoadLevel("Start");
        }
        else if(Input.GetMouseButtonDown(0)) {
            Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = (CursorLockMode.Locked != CursorLockMode.Confined);
        }
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
