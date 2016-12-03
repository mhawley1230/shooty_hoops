using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		transform.rotation *= Quaternion.Euler (0, mouseX, 0);
		Camera camera = GetComponentInChildren<Camera> ();
		camera.transform.rotation *= Quaternion.Euler (-mouseY, 0, 0);
	}
}
