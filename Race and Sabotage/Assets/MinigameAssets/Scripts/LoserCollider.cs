using UnityEngine;
using System.Collections;

public class LoserCollider : MonoBehaviour {

	private LevelManager levelManager;
    public GameObject LoadingBar;
	
	void OnTriggerEnter2D (Collider2D trigger) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
        //levelManager.LoadLevel("Lose Screen");
        Application.LoadLevel(Application.loadedLevel);
        DontDestroyOnLoad(LoadingBar);

    }
	
	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");	
	}
	
}
