using System.Collections;
using System.Collections.Generic;
using UnityEngine;public class Furnitures : MonoBehaviour {

	Rigidbody rb;
	public GameObject gameController;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
		// rb.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		int timer = gameController.GetComponent<GameController>().getTimer();


		if(timer == 60) {
			// rb.AddForce(new Vector3(500f,500f,-500f));
			rb.AddForce(Vector3.up);
			rb.useGravity = false;
		}
	}
}
