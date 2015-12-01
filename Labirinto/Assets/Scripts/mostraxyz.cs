using UnityEngine;
using System.Collections;

public class mostraxyz : MonoBehaviour {

	// Use this for initialization
	public Vector3 position;
	public Vector4 rotation;
	void Start () {
		position = this.GetComponent<Transform> ().position;
		rotation = new Vector4 (this.GetComponent<Transform> ().rotation.x, this.GetComponent<Transform> ().rotation.y, this.GetComponent<Transform> ().rotation.z, this.GetComponent<Transform>().rotation.w);
	}
	
	// Update is called once per frame
	void Update () {
		position = this.GetComponent<Transform> ().position;
		rotation = new Vector4 (this.GetComponent<Transform> ().rotation.x, this.GetComponent<Transform> ().rotation.y, this.GetComponent<Transform> ().rotation.z, this.GetComponent<Transform>().rotation.w);
	
	}
}
