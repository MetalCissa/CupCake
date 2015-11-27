using UnityEngine;
using System.Collections;

public class AtiraFlecha : MonoBehaviour {
	public GameObject flecha;
	public float tempo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tempo += Time.deltaTime;
		if(tempo >= 0.1){
			GameObject t = Instantiate(flecha, this.GetComponent<Transform>().position, Quaternion.identity) as GameObject;
			GameObject.Destroy(t,2);
			tempo = 0;
		}
	}
}
