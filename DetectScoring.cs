﻿using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {
	public int pointsPerHit = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision collision) {
		ScoreKeeper scoreKeep = FindObjectOfType<ScoreKeeper>();
		scoreKeep.IncrementScore(pointsPerHit);
	}
}
