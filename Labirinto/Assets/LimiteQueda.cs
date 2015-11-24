using UnityEngine;
using System.Collections;

public class LimiteQueda : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other ){
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Collider> ().isTrigger = false;
			other.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
		}
	}
}
