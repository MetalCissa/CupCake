using UnityEngine;
using System.Collections;

public class AudioManagement : MonoBehaviour {

	public AudioClip audioClip;

	private Animator anim;

	void Start(){
		anim = GetComponent<Animator> ();
	}

	void Update () {
		if (Input.GetAxis("Vertical") != 0.0f) {
			if (!GetComponent<AudioSource> ().isPlaying)
			GetComponent<AudioSource> ().Play ();
		}
	}
}
