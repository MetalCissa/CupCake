using UnityEngine;
using System.Collections;

public class FlechaNv7 : MonoBehaviour {

	private int velocidade;
	// Use this for initialization
	void Start () {
		this.transform.Rotate (new Vector3( 0, -164, 3.6f));
		velocidade = 2;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(velocidade *Time.deltaTime,0,0);
	}
	
	void OnTriggerEnter(Collider other) {
//		Debug.Log("Passsei nome = "+other.gameObject.tag +(other.gameObject.tag=="Parede nv 8") );
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
			Destroy(this.gameObject);
		} else if(other.gameObject.tag == "Parede nv 8"){
			Destroy(this.gameObject);
		}
	}
}
