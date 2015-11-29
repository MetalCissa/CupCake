using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {
	private int velocidade;
	private float time;
	public bool vai;

	public Vector3 posicaoinicial;
	// Use this for initialization
	void Start () {
		vai = false;
		this.velocidade = 5;
		posicaoinicial = this.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		if (vai) {
            this.GetComponent<Renderer>().enabled = true;
			this.transform.Translate (velocidade * Time.deltaTime, 0, 0);		
		}
	
	}

	void OnCollisionEnter(Collision other) {
		//Debug.Log("Passsei nome " +other.gameObject.tag );

        if(other.gameObject.tag == "Cortina")
        {
            vai = true;
        }else if (!(other.gameObject.tag == "Parede nv 6"))
        {
            this.transform.position = posicaoinicial;
            this.GetComponent<Renderer>().enabled = false;
            vai = false;
        }
        if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
		}

			
	}
}
