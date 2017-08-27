//
//  Bricks.cs
//  Brick Buster
//
//  Created on August 25, 2017 by Animesh Mishra
//  Copyright (c) 2017 Animesh Ltd
//  All Rights Reserved
//  

using UnityEngine;
using UnityEngine.SceneManagement;

public class Bricks : MonoBehaviour {

    public int maxHits;
    private int timesHit;
    private LevelManager levelManager;

	void Start () {
        timesHit = 0;
        levelManager = FindObjectOfType<LevelManager>();
	}
	
    void Update () {
        Debug.Log(GameObject.FindGameObjectsWithTag("brick").Length);

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        timesHit++;
        if(timesHit >= maxHits) {
            Destroy(gameObject);
        }
        else if (maxHits - timesHit == 1) {
            var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = new Color(109/255f, 243/255f, 1f, 1f);

        } 
    }
}
