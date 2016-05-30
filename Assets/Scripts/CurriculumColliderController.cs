﻿using UnityEngine;
using System.Collections;

public class CurriculumColliderController : MonoBehaviour {

	private MouseRotate curriculumController;

	// Use this for initialization
	void Start () {
		curriculumController = GameObject.Find ("Curriculum").GetComponent<MouseRotate> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if (col.tag == "Player") {
			curriculumController.Show();
		}
	}
}