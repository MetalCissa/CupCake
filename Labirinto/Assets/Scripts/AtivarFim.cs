using UnityEngine;
using System.Collections;

public class AtivarFim : MonoBehaviour {

	public GameObject target;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			target.SetActive(true);
		}
	}
}
