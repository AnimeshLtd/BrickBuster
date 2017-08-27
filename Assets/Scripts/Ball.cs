//
//  Ball.cs
//  Brick Buster
//
//  Created on August 25, 2017 by Animesh Mishra
//  Copyright (c) 2017 Animesh Ltd
//  All Rights Reserved
//  

using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    private Vector3 paddleToBallVector;
    private Rigidbody2D ballBody;
    private bool gameStarted = false;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        paddle = FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        ballBody = GetComponent<Rigidbody2D>();
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if(!gameStarted) 
            this.transform.position = paddle.transform.position + paddleToBallVector;

        if(Input.GetMouseButton(0)) {
            gameStarted = true;
            ballBody.velocity = new Vector2(9, 9);
        }

		if (GameObject.FindGameObjectsWithTag("brick").Length == 0)
		{
			levelManager.LoadNextLevel();
		}
	}
}
