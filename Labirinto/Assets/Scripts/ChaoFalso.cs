﻿using UnityEngine;
using System.Collections;

public class ChaoFalso : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Collider> ().isTrigger = true;
		}
	}
}
