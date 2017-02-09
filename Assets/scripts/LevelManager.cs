using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	int currentIndex;
	public float timeTillNextLevel  = 5.0f;
	// Use this for initialization
	void Start () {
		//Load Scene
		currentIndex = SceneManager.GetActiveScene().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {

		if (timeTillNextLevel > 0) {
			timeTillNextLevel -= Time.deltaTime;
			if (timeTillNextLevel <= 0) {
				LoadNextScene ();
			}
		//	print ("Time till next level " + timeTillNextLevel);
		}
	}

	public void LoadNextScene () { 
		SceneManager.LoadScene(++currentIndex);
	}

	public void LoadPreviousScene () {
		SceneManager.LoadScene (--currentIndex);
	}
}
