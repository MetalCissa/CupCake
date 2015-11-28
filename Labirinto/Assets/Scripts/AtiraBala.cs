using UnityEngine;
using System.Collections;

public class AtiraBala : MonoBehaviour {
	public GameObject bala;
	public float tempo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tempo += Time.deltaTime;
		if(tempo >= 5){
			bala.GetComponent<Bala>().vai = true;
//			GameObject t = Instantiate(bala, this.GetComponent<Transform>().position, Quaternion.identity) as GameObject;
			tempo = 0;
		}
	}

}
