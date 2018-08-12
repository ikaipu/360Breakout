using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudioScript : MonoBehaviour {

	[SerializeField] AudioClip _audioClip;
    [SerializeField] [Range(0.0f, 1.0f)] float _volume = 1;
    AudioSource _audioSource;
 
    void Awake ()
    {
        _audioSource = gameObject.AddComponent<AudioSource> ();
        if (_audioClip != null)
            _audioSource.clip = _audioClip;
        _audioSource.playOnAwake = false;
        _audioSource.volume = _volume;
        _audioSource.Play();

				
				// PlayerPrefs.SetString("testname","testvalue");
				// PlayerPrefs.Save();
				Debug.Log("Arang player pref " + PlayerPrefs.GetInt("highScore"));
    }

}
