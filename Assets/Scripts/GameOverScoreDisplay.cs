using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

	Text text;
	ScoreAbsorber scoreAbsorber;

	void Start () {
		text = GetComponent<Text> ();	
		scoreAbsorber = FindObjectOfType<ScoreAbsorber> ();
		text.text = "Score: " + scoreAbsorber.score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
