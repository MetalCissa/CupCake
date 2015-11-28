using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {
	private int velocidade;
	private float time;
	public bool vai;
//	public bool roda;
	public Vector3 posicaoinicial;
	// Use this for initialization
	void Start () {
		vai = false;
//		if(roda) this.transform.Rotate (new Vector3( 0, 50, 0));
		this.velocidade = 5;
		posicaoinicial = this.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		if (vai) {
			if(!this.gameObject.activeSelf){
				this.gameObject.SetActive(true);
			}
			time += Time.deltaTime;
//		if (time >= 1) {
			this.transform.Translate (velocidade * Time.deltaTime, 0, 0);
//			this.GetComponent<Rigidbody> ().AddForce (new Vector3 (500, 0, 0));
			time = 0;
//		}
		
		}
	
	}

	void OnCollisionEnter(Collision other) {
//		Debug.Log("Passsei nome " );
		if (other.gameObject.tag == "Player") {
			vai = false;
			other.gameObject.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
			this.transform.position = posicaoinicial;
//			this.gameObject.SetActive = false;
			this.gameObject.SetActive(false);
		} else if(other.gameObject.tag == "Parede nv 4"){
			vai = false;
			this.gameObject.SetActive(false);
			this.transform.position = posicaoinicial;
		}
	}
}
