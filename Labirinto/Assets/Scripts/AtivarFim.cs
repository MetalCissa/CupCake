using UnityEngine;
using System.Collections;

public class AtivarFim : MonoBehaviour {
	public Camera camfim;
	public GameObject nevoa; 
	public GameObject luz;
	public GameObject target;
	private bool vai;
	private float tempo;

	void Start(){
		tempo = 0;
		vai = false;
	}
	void Update(){
		tempo+= Time.deltaTime;
		if(vai){

			if(tempo >= 2){
				target.SetActive(true);
				camfim.enabled = true;
				luz.GetComponent<Climatizacao>().activeScript = false;
				nevoa.SetActive(false);
			}

		}
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			vai = true;
			tempo = 0;
		}
	}
}
