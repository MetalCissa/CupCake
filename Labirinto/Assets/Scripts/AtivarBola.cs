using UnityEngine;
using System.Collections;

public class AtivarBola : MonoBehaviour {
	public GameObject bola;
	public Camera newCamera;


	private bool cameraMudou;
	// Use this for initialization
	void Start () {
		cameraMudou = false;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			if(bola !=null){
				bola.SetActive (true);
			}
			newCamera.enabled = true;
		}
	}
}
