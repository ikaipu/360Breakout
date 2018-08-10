using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour {

	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = false;
		rb.AddForce(new Vector3(100f,100f,0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
