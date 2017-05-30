using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ball;
	public float ballSpeed = 10f;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Camera camera = GetComponentInChildren<Camera> ();

			GameObject instance = Instantiate (ball);
			instance.transform.position = transform.position;
			instance.GetComponent<Rigidbody> ().velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
		}
	}
}
