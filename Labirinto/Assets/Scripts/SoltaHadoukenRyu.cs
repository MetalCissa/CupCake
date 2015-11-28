using UnityEngine;
using System.Collections;

public class SoltaHadoukenRyu : MonoBehaviour {
	private bool podeSoltar;
	public GameObject poder;
	public Transform posicao;
	private float tempo;
	
	// Use this for initialization
	void Start () {
		podeSoltar = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		tempo += Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Q) && podeSoltar){
			GameObject hadouken = Instantiate(poder, posicao.position, posicao.rotation) as GameObject;
			Destroy (hadouken, 3);
			tempo = 0;
			podeSoltar = false;
		}
		if (tempo >= 3 && !podeSoltar) {
			podeSoltar = true;
		}
	
	}
	public void setPodeSoltar(bool x){
		this.podeSoltar = x;
	}

}
