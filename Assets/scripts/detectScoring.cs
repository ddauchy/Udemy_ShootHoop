using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectScoring : MonoBehaviour {
	public int value = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		ScoreKeeper scoreObj = FindObjectOfType<ScoreKeeper> ();
		scoreObj.IncrementScore (value);

	}
}
