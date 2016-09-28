using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mousex = Input.GetAxis ("Mouse X");
		float mousey = Input.GetAxis ("Mouse Y");
		float rotationSpeed = 5.0f;
			
		transform.localRotation = Quaternion.Euler (0, mousex*rotationSpeed, 0) * transform.localRotation;
		Camera camera = GetComponentInChildren<Camera> ();	
		camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler (-mousey*rotationSpeed, 0, 0);

	}
}
