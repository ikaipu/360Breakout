﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {
	// public GameObject gameController;
	// Use this for initialization

	public GameObject gameController;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision col){
		Debug.Log("hit");
		string name = col.collider.gameObject.name ;
		if(name == "Sphere(Clone)") {
			gameController.GetComponent<GameController>().subtractHp(10);
		} else {

			gameController.GetComponent<GameController>().subtractHp(30);
		}
		GetComponent<AudioSource>().Play();
	}
}
