using UnityEngine;
using System.Collections;

public class BigBallMov : MonoBehaviour {

	public bool diminuirBola = false;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		this.gameObject.SetActive (false);
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.activeSelf) {
			Debug.Log("to aqui");
			rb.AddForce (new Vector3 (0f, 0f, 3f));
			if (diminuirBola) {
				Vector3 currentScale = this.transform.localScale;
				currentScale.x -= 0.002f;
				currentScale.y -= 0.002f;
				currentScale.z -= 0.002f;
				this.transform.localScale = currentScale;

				if (currentScale.x <= 0) {
					Destroy (this.gameObject);
				}
			}
		}
	}
	void OnCollisionEnter(Collision other) {
		//		Debug.Log("Passsei nome " );
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Transform> ().position = new Vector3 (-4.38f, 6.52f, 12.38f);
		}
	}
	 	 	
}
