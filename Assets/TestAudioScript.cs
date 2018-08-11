using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudioScript : MonoBehaviour {

	// Use this for initialization
	public AudioSource source;
	public AudioClip clip;
	void Start () {
    source = GetComponent<AudioSource>();
		if(null == source)
			Debug.Log("wala");
		else
			Debug.Log("naa");
    source.Play(44100);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
