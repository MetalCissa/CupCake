using UnityEngine;
using System.Collections;

public class Hadouken : MonoBehaviour {
//	public GameObject personagem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(0,0,3*Time.deltaTime);
	
	}

	void OnTriggerEnter(Collider other) {
        //Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Caveira") {
			Destroy (other.gameObject);
		}
		if (!(other.gameObject.tag == "Player") && !(other.gameObject.tag == "Untagged")) {
			Destroy (this.gameObject);
		}
	

	
//		personagem.GetComponent<SoltaHadoukenRyu> ().setPodeSoltar(true);
	}
}
