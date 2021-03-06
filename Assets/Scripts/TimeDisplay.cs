﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	Text text;
	LevelManager levelManager;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		levelManager = FindObjectOfType<LevelManager> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = "Time remaining: " + levelManager.timeTillNextLevel;
	}
}
