using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			instance.transform.position = transform.position;

			Camera camera = GetComponentInChildren<Camera> ();
			rb.velocity = camera.transform.localRotation * (Vector3.forward * speed);
		}
	}
}