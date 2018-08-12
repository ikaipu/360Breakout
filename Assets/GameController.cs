using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// Use this for initialization
	public Text timerText;
	public Text hpText;

	public RawImage image;
    public AudioClip sadBirthday;
    public AudioClip creepyBirthday;

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

				for(int i = 0; i <  sphereInstances.Count; i++) {
					Destroy(sphereInstances[i]);
				}
				sphereInstances.Clear();
				timerText.text = "GAME OVER";
				hpText.text = "Press any key to restart";


				int currentHighScore = PlayerPrefs.GetInt("highScore");

				if(timer > currentHighScore) 
                {
                    transform.GetComponent<AudioSource>().clip = creepyBirthday;
					image.enabled=true;
					PlayerPrefs.SetInt("highScore",(int) timer);
					PlayerPrefs.Save();

					timerText.text = "NEW HIGH SCORE!!!";
				} 
                else {
                    transform.GetComponent<AudioSource>().clip = sadBirthday;
                }
            transform.GetComponent<AudioSource>().Play();
		}
	void Start () {
		//use this to reset high score
		// PlayerPrefs.SetInt("highScore",0);

		resetGame();
  }
	
	// Update is called once per frame
	void Update () {
    if(isGameOver && Input.anyKeyDown){
			resetGame();
    }
	}

	void resetGame(){

		image.enabled=false;
		for(int i = 0; i <  sphereInstances.Count; i++) {
      Destroy(sphereInstances[i]);
    }
    sphereInstances.Clear();
		isGameOver = false;
		hp = 100;
		timer = 0f;

		hpText.text = "HP: " + hp;
		StartCoroutine(StartCountdown());
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
