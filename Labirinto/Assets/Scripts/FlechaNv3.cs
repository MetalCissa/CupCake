using UnityEngine;
using System.Collections;

public class FlechaNv3 : MonoBehaviour {
	private int velocidade;
	// Use this for initialization
	void Start () {
		velocidade = 2;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(velocidade *Time.deltaTime,0,0);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
			Destroy(this.gameObject);
		}else if(other.gameObject.tag == "Parede nv 4"){
			Destroy(this.gameObject);
		}
	}

}
