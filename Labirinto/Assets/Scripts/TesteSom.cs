using UnityEngine;
using System.Collections;

public class TesteSom : MonoBehaviour {

    public AudioClip audioClip;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
       if (!GetComponent<AudioSource>().isPlaying)
                GetComponent<AudioSource>().Play();

    }
}
