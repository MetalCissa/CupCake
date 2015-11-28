using UnityEngine;
using System.Collections;

public class Caveira : MonoBehaviour {
	public GameObject fogo;
	public Transform posicao;
	private float tempo;
	private Vector3 posicaofogo;
	private bool fogozao;


	// Use this for initialization
	void Start () {

		fogozao = false;
//		posicaofogo = new Vector3 (this.GetComponent<Transform> ().position.x - 0.12f, this.GetComponent<Transform> ().position.y - 0.065f, this.GetComponent<Transform> ().position.z + 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		tempo += Time.deltaTime;

		if (tempo >= 5 && !fogozao) {
//			GameObject t = Instantiate (fogo, posicaofogo, Quaternion.identity) as GameObject;
			GameObject t = Instantiate (fogo, posicao.position, Quaternion.identity) as GameObject;
			Destroy ( t, 10);
			tempo = 0;
			fogozao = true;
		} else {
			if(tempo >= 10 && fogozao){
				fogozao = false;
				tempo = 0;
			}
		
		}
	}
}
