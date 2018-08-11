using System.Collections;
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
		gameController.GetComponent<GameController>().subtractHp(true);
	}
}
