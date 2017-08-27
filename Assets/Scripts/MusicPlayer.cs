//
//  MusicPlayer.cs
//  Brick Buster
//
//  Created on August 26, 2017 by Animesh Mishra
//  Copyright (c) 2017 Animesh Ltd
//  All Rights Reserved
//

using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    private void Awake() {
		// If there's already a MusicPlayer instance in game, stop any 
		// others from spawning.
		if (instance) {
			Destroy(gameObject);
		}
		else {
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
    }

    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
