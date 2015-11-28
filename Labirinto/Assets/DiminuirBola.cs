using UnityEngine;
using System.Collections;

public class DiminuirBola : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bola") {
			other.GetComponent<BigBallMov> ().diminuirBola = true;
		}
	}
}
