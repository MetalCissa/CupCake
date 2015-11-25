using UnityEngine;
using System.Collections;

public class Portas : MonoBehaviour {
	private float alturaInicial;
	private float alturaFinal;
	private int totalFrames;
	private Transform meuTransform;
	public float tempo;
	public float tempoSubirDescer;
	public int subirDescer;
	public int segundosFechada;
	public int segundosLevantada;

	// Use this for initialization
	void Start () {
		meuTransform = this.GetComponent<Transform>();
		alturaInicial = meuTransform.position.y;
		alturaFinal = 8.6f;
		totalFrames = 40;
		subirDescer = 0;
	}
	
	// Update is called once per frame
	void Update () {

		tempo += Time.deltaTime;
		tempoSubirDescer += Time.deltaTime;

		if(tempoSubirDescer >= segundosFechada && tempoSubirDescer <= segundosFechada+2 && subirDescer != 1){
			subirDescer = 1;
		}else if(tempoSubirDescer >= segundosFechada+segundosLevantada+4 && tempoSubirDescer <= segundosFechada+segundosLevantada+6){
			subirDescer = -1;
		}

		if(subirDescer == 1){
			if(meuTransform.position.y < alturaFinal){
				if(tempo >= 0.1){
					meuTransform.position = new Vector3(meuTransform.position.x, meuTransform.position.y + (alturaFinal - alturaInicial)/totalFrames, meuTransform.position.z);
					tempo = 0;
				}
			}else{
				subirDescer = 0;
			}
		}else if(subirDescer == -1){
			if(meuTransform.position.y > alturaInicial){
				if(tempo >= 0.1){
					meuTransform.position = new Vector3(meuTransform.position.x, meuTransform.position.y - (alturaFinal - alturaInicial)/(totalFrames/2), meuTransform.position.z);
					tempo = 0;
				}
			}else{
				subirDescer = 0;
				tempoSubirDescer = 0;
			}
		}



	
	}
}
