using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {

	public Collider expectedCollider;
	public ScoreKeeper scoreKeeper;

	void Start() {
		scoreKeeper = FindObjectOfType<ScoreKeeper> ();
	}

	public void ExpectTrigger(Collider ball) {
		expectedCollider = ball;
	}

	void OnTriggerEnter(Collider collider) {
		if (collider == expectedCollider) {
			scoreKeeper.IncrementScore (1);
		}

	}
}
