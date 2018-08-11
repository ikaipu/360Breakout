using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// Use this for initialization
	public Text timerText;
	public Text hpText;

	 List<GameObject> sphereInstances = new List<GameObject>();
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
							sphereInstances.Add(Instantiate(Sphere, new Vector3(x,y,z), Quaternion.identity));
						}
						timerText.text = "Counter: " + timer;
						yield return new WaitForSeconds(1.0f);
						timer++;
				}
				
				timerText.text = "GAME OVER";
				hpText.text = "Press any key to restart";
		}
	void Start () {

		hpText.text = "HP: " + hp;
		StartCoroutine(StartCountdown());

  }
	
	// Update is called once per frame
	void Update () {
		Debug.Log("ara sia ay" +  sphereInstances.Count);
    if(isGameOver && Input.anyKeyDown){

			for(int i = 0; i <  sphereInstances.Count; i++)
     {
         Destroy(sphereInstances[i]);
     }
     sphereInstances.Clear();
			isGameOver = false;
			hp = 100;
			timer = 0f;


			hpText.text = "HP: " + hp;
			StartCoroutine(StartCountdown());
    }
	}

	public void subtractHp(bool isGameOver){
		int hp = this.hp - 100;
		if(hp <= 0) {
			this.isGameOver = isGameOver;
		} else {
			this.hpText.text = "HP: " + hp;
		}
	}
	
}
