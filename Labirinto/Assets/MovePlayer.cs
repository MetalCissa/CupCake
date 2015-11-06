using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public float speed = 5.0f;

	// Update is called once per frame
	void Update () {
		float movVertical =  Input.GetAxis("Vertical");
		float movHorizontal =  Input.GetAxis("Horizontal");

		transform.Translate (new Vector3(movHorizontal * Time.deltaTime, 0, movVertical * Time.deltaTime));
	}
}
