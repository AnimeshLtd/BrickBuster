//
//  Paddle.cs
//  Brick Buster
//
//  Created on August 25, 2017 by Animesh Mishra
//  Copyright (c) 2017 Animesh Ltd
//  All Rights Reserved
//  

using UnityEngine;

public class Paddle : MonoBehaviour {

    float mousePositionInBlocksX;

    // We have chosen to make 72 pixel wide blocks.
    // Width of frame = 1440
    // 1440 / 72 = 20
    const int screenWidthInBlocks = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mousePositionInBlocksX = (Input.mousePosition.x / Screen.width) * screenWidthInBlocks;

        Vector3 newPaddlePosition = new Vector3(mousePositionInBlocksX, this.transform.position.y);
        newPaddlePosition.x = Mathf.Clamp(mousePositionInBlocksX, 0.5f, 19.5f);

        this.transform.position = newPaddlePosition;
	}
}
