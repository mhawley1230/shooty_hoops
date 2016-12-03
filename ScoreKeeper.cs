using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	int score = 0;

	void Start () {
	
	}

	void Update () {
	
	}

	public void IncrementScore (int amount) {
		score += amount;
		print("Score: " + score);
	}
}
