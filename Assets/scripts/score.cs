﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

	public int myscore = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		myscore++;
		print ("yeeeeah " + myscore);
	}
}
