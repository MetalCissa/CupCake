using UnityEngine;
using System.Collections;

public class Fogo30 : MonoBehaviour {
//	public GameObject caveira;
	// Use this for initialization
	void Start () {
		this.GetComponent<Transform>().Rotate( 0,- 30, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
		}
	}
}
