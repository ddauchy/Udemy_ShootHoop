using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

	public static int myscore = 0;
	public int scoretest = 0;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		myscore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncrementScore(int value) {
		myscore += value;
		print ("Score:: " + myscore);
		scoretest = ScoreKeeper.myscore;
	}
}
