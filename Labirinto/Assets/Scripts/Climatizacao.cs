using UnityEngine;
using System.Collections;

public class Climatizacao : MonoBehaviour {
	public GameObject chuva;
	public GameObject nevoa;
	public float tempo;
	private int aux;
	private bool primeirax;
	private bool entrou;
	public bool activeScript;
	// Use this for initialization
	void Start () {
		activeScript = true;
		entrou = false;
		primeirax = true;
		aux = 160;
		tempo = 0;
		chuva.SetActive(false);
		nevoa.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(activeScript){
			tempo += Time.deltaTime;
			if (tempo >= 10 && tempo < 11) {
				if(!primeirax){
					if(!entrou){
						this.transform.Rotate (new Vector3 (-aux, 0, 0));
						entrou = true;
					}
				}
			} else if (tempo >= 16 && tempo < 16.2) {
				chuva.SetActive(true);
				entrou = false;
			} else if (tempo >= 30 && tempo < 30.2) {
				if(primeirax){
					primeirax = false;
				}
				if(!entrou){
					this.transform.Rotate (new Vector3 (aux, 0, 0));
					entrou = true;
				}
			} else if (tempo >= 40 && tempo < 40.2) {
				nevoa.SetActive(true);
			}else if (tempo >= 70 && tempo < 70.2) {
				tempo = 0;
				chuva.SetActive(false);
				nevoa.SetActive(false);
				entrou = false;
			}
		}
	}
}
