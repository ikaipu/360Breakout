using System.Collections;
using System.Collections.Generic;
using UnityEngine;public class Furnitures : MonoBehaviour {

	Rigidbody rb;
	public GameObject gameController;
	private Vector3 initialPosition;

	Quaternion initialRotation;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
		initialPosition = transform.position;
		// initialPosition = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		initialRotation = transform.rotation;
		// rb.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		int timer = gameController.GetComponent<GameController>().getTimer();

		bool isGameOver = gameController.GetComponent<GameController>().getIsGameOver();

		if(timer == 60) {
			// rb.AddForce(new Vector3(500f,500f,-500f));
			rb.AddForce(Vector3.up);
			rb.useGravity = false;
		}

		if(isGameOver){
			this.transform.rotation = initialRotation;
			this.transform.position = initialPosition;
			rb.useGravity = false;
		}
	}
}
