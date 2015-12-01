using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	void Start(){
		offset = transform.position - player.transform.position;
	}
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
		transform.Rotate (new Vector3 (0, Input.GetAxis ("Horizontal") * 0.10f, 0));
	}
}
