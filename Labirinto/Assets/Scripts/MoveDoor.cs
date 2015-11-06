using UnityEngine;
using System.Collections;

public class MoveDoor : MonoBehaviour {

    public float speed;
	public KeyCode kc;

	private Rigidbody rb;

	private float initialY;
	public void Start(){ 
		rb = GetComponent<Rigidbody> ();
	}

	public void Update () {
		if (Input.GetKey (kc)) {

			Vector3 movement = new Vector3 (0.0f, 2, 0.0f);
			rb.AddForce (movement * speed);
		}
	}
}
