using UnityEngine;
using System.Collections;

public class MudarCamera : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)){
			if(cam1.enabled){
				cam1.enabled = false;
				cam2.enabled = true;
			}else{
				cam1.enabled = true;
				cam2.enabled = false;
			}
		}
	
	}
}
