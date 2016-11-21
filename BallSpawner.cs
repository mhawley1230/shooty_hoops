﻿using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;

	void Start () {
		
	}

	void Update () {
		float speed = 5.0F;
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.forward * speed;
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.left * speed;
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.right * speed;
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.back * speed;
		}
	}
}
