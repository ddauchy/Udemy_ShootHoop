using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryTrigger : MonoBehaviour {
	public SecondaryTrigger bottomTrigger;

	void Start() {
		bottomTrigger = GetComponentInChildren<SecondaryTrigger> ();
	}

	void OnTriggerEnter(Collider collider) {
		bottomTrigger.ExpectTrigger (collider);
		print ("trigger entered" + collider);
	}
}
