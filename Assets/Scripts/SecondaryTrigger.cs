﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {

	public int scorePerHit = 1;

	Collider expectedCollider;
		
	public void ExpectCollider (Collider collider) {
		expectedCollider = collider;
	}

	void OnTriggerEnter (Collider otherCollider) {
		if (otherCollider == expectedCollider) {
			ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
			scoreKeeper.IncrementScore (scorePerHit);
		}
	}
}
