using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// Use this for initialization
	public Text text;

	private GameObject instanceOfBall;
    float timer = 0f;
	private bool isGameOver = false;

	public GameObject Sphere;
		public IEnumerator StartCountdown(float countdownValue = 0)
		{
				while (!isGameOver)
				{
						if(timer % 5 == 0) {

							Instantiate(Sphere, new Vector3(Sphere.transform.position.x,Sphere.transform.position.y,Sphere.transform.position.z), Quaternion.identity);
						}
						text.text = "Countdown: " + timer;
						yield return new WaitForSeconds(1.0f);
						timer++;
				}
				
				text.text = "GAME OVER";
		}
	void Start () {
		StartCoroutine(StartCountdown());

  }
	
	// Update is called once per frame
	void Update () {
	}

	public void setGameOver(bool isGameOver){
		this.isGameOver = isGameOver;
	}
	
}
