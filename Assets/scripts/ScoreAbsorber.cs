﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {
	public int score;
	// Use this for initialization
	void Start () {
		ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper> ();
		score = 1;
		if (oldKeeper) {
			score = ScoreKeeper.myscore;
			Destroy (oldKeeper.gameObject);
		}
	}
}