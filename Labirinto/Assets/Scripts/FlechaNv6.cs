using UnityEngine;
using System.Collections;

public class FlechaNv6 : MonoBehaviour {

	private int velocidade;
	// Use this for initialization
	void Start () {
		this.transform.Rotate (new Vector3( 85, -123, 100));
//		this.transform.rotation.x = 85f;
//		this.transform.rotation.y = -123f;
//		this.transform.rotation.z = 100f;
//			
		velocidade = 2;
	}
	
	// Update is called once per frame
	void Update () {
		float vel = velocidade * Time.deltaTime;
		this.transform.Translate(vel,0,vel);
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
			Destroy(this);
		}else if(other.gameObject.tag == "Parede nv 7"){
			Destroy(this);
		}
	}
}
