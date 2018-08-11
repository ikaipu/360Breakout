using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// Use this for initialization
	public Text timerText;
	public Text hpText;

	private GameObject instanceOfBall;
    float timer = 0f;
	private bool isGameOver = false;

	private int hp = 100;

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
						timerText.text = "Counter: " + timer;
						yield return new WaitForSeconds(1.0f);
						timer++;
				}
				
				timerText.text = "GAME OVER";
		}
	void Start () {

		hpText.text = "HP: " + hp;
		StartCoroutine(StartCountdown());

  }
	
	// Update is called once per frame
	void Update () {
	}

	public void subtractHp(bool isGameOver){
		int hp = this.hp - 7;
		this.hpText.text = "HP: " + hp;
		return;
		this.isGameOver = isGameOver;
	}
	
}
