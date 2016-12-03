using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	private int score = 0;

	void Start () {
	
	}

	void Update () {
	
	}

	void OnCollisionEnter (Collision collision) {
		score++;
		print("Score: " + score);
	}
}
