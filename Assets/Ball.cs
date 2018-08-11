using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

	// Use this for initialization
	Rigidbody rb;
	
	public Text text;

	float currCountdownValue;
		public IEnumerator StartCountdown(float countdownValue = 10)
		{
				currCountdownValue = countdownValue;
				while (currCountdownValue > 0)
				{
						Debug.Log("Countdown: " + currCountdownValue);

						text.text = "Countdown: " + currCountdownValue;	
						yield return new WaitForSeconds(1.0f);
						currCountdownValue--;
				}
		}
	void Start () {

		text.text = "gina edit na";	
		Debug.Log("start ball");
		rb=GetComponent<Rigidbody>();
		rb.isKinematic = false;
		rb.AddForce(new Vector3(0,50f,-50f));

		
		 StartCoroutine(StartCountdown());
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisioEnter(Collision col){
		Debug.Log("nicolllide ball");
	}
}
