using UnityEngine;
using System.Collections;

public class Portas : MonoBehaviour {
	private float alturaInicial;
	public float alturaFinal;
	private Transform meuTransform;
	private float tempo;
	private float tempoSubirDescer;
	private int subirDescer;
	public int segundosFechada;
	public int segundosLevantada;
//	public float positiony;
//	public float aumentandoporzeroum;
	private int contantbug;
	public float segundosDescer;
	public float segundosSubir;

	// Use this for initialization
	void Start () {
		meuTransform = this.GetComponent<Transform>();
		segundosSubir = 4f;
		segundosDescer = 0.5f;
		alturaInicial = meuTransform.position.y;
		alturaFinal = 8.8f;
		subirDescer = 0;
		contantbug = 0;
	}
	
	// Update is called once per frame
	void Update () {
//		positiony = meuTransform.position.y;

		tempo += Time.deltaTime;
		tempoSubirDescer += Time.deltaTime;

		if(tempoSubirDescer >= segundosFechada && tempoSubirDescer <= segundosFechada+2 && subirDescer != 1){
			subirDescer = 1;
		}else if(tempoSubirDescer >= segundosFechada+segundosLevantada+4 && tempoSubirDescer <= segundosFechada+segundosLevantada+6){
			subirDescer = -1;
		}

		if(subirDescer == 1){
			if(meuTransform.position.y < alturaFinal){
//				Debug.Log("passei aqui y = " + meuTransform.position.y+ " altura final = "+alturaFinal);
				if(tempo >= 0.1){
					meuTransform.position = new Vector3(meuTransform.position.x, meuTransform.position.y + (alturaFinal - alturaInicial)/(segundosSubir/0.1f), meuTransform.position.z);
					tempo = 0;
				}
			}else{
				subirDescer = 0;
			}
		}else if(subirDescer == -1){
			if(meuTransform.position.y > alturaInicial){
				if(tempo >= 0.1){
//					Debug.Log("Passei aqui:" + meuTransform.position.y +" "+alturaInicial);
					if(contantbug < ((segundosDescer/0.1f) - 1)){
						meuTransform.position = new Vector3(meuTransform.position.x, meuTransform.position.y - (alturaFinal - alturaInicial)/(segundosDescer/0.1f), meuTransform.position.z);
					}else{
						meuTransform.position = new Vector3(meuTransform.position.x, alturaInicial, meuTransform.position.z);
					}
					tempo = 0;
					contantbug++;
//					Debug.Log("Sai aqui:" + meuTransform.position.y +" "+alturaInicial);
				}
				this.GetComponent<Collider>().isTrigger = true;
			}else{
				subirDescer = 0;
				tempoSubirDescer = 0;
				this.GetComponent<Collider>().isTrigger = false;
				contantbug = 0;
			}
		}



	
	}

	void OnTriggerEnter(Collider other ){
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
		}
	}
}
