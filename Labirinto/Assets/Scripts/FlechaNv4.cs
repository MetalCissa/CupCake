﻿using UnityEngine;
using System.Collections;

public class FlechaNv4 : MonoBehaviour {
	
	private int velocidade;
	// Use this for initialization
	void Start () {
		this.transform.Rotate (new Vector3( -0.9f, 143.2f, 0.05f));
		velocidade = 2;
	
	}
	
	// Update is called once per frame
	void Update () {
		float vel = velocidade *Time.deltaTime;
		this.transform.Translate(vel,0,0);
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
			Destroy(this.gameObject);
		}else if(other.gameObject.tag == "Parede nv 5"){
			Destroy(this.gameObject);
		}
	}
}
