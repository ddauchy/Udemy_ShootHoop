using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour {
	Text scoreText;
	ScoreAbsorber scoreAbsorber;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
		scoreAbsorber = FindObjectOfType<ScoreAbsorber> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + scoreAbsorber.score;
	}
}
