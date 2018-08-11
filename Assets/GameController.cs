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

							// float x = Sphere.transform.position.x;
							// float y = Sphere.transform.position.y;
							// float z = Sphere.transform.position.z;
							float x = Random.Range(Sphere.transform.position.x, Sphere.transform.position.x +5.0f);
							float y = Random.Range(Sphere.transform.position.y, Sphere.transform.position.y + 5.0f);
							float z = Random.Range(Sphere.transform.position.z, Sphere.transform.position.z + 5.0f);
							Instantiate(Sphere, new Vector3(x,y,z), Quaternion.identity);
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
