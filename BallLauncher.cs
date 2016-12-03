using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float speed = 5.0f;

	void Start () {
	
	}

	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.forward * speed;
		}
	}
}
