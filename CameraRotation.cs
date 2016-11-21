using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		transform.rotation *= Quaternion.Euler (0, 1, 0);
	}
}
