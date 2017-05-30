using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	float rotationSpeed = 5f;
	
	// Update is called once per frame
	void Update () {
		Camera camera = GetComponentInChildren<Camera> ();

		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		transform.localRotation = Quaternion.Euler (0, mouseX, 0) * transform.localRotation;
		camera.transform.localRotation = Quaternion.Euler (-mouseY, 0, 0) * camera.transform.localRotation;
	}
}
