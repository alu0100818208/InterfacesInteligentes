﻿using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour, IGvrGazeResponder {

	public void OnGazeEnter() {

	}

	public void OnGazeExit() {

	}

	public void OnGazeTrigger() {
		transform.position += new Vector3 (0f, 3f, 0f); 
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveUpPlatform() {
		//transform.position += new Vector3 (0f, 3f, 0f);
	}
}
