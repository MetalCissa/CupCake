using UnityEngine;
using System.Collections;

public class CameraAntiga : MonoBehaviour {
	public Camera newCamera;
	public Camera oldCamera;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bola") {
			newCamera.enabled = false;
			oldCamera.enabled = true;
		}
	}
}
