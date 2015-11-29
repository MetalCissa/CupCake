using UnityEngine;
using System.Collections;

public class AtivarBola : MonoBehaviour {
	public GameObject bola;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			bola.SetActive(true);
		}
	}
}
