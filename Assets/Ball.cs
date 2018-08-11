using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

	// Use this for initialization
	Rigidbody rb;


AudioSource src;
	void Start () {

    rb=GetComponent<Rigidbody>();
		// audioSource.pla;
		// audioData.GetComponent<AudioSource>().Play();
		// rb.isKinematic = false;
		// rb.AddForce(new Vector3(0,50f,-50f));
		rb.AddForce(new Vector3(-50f,0,0));


		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision col){
		// rb.isKinematic = false;
		// rb.AddForce(new Vector3(0,50f,-50f));
	}
	
}
