using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D collision) {
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("GameOver");
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision");
    }
}
