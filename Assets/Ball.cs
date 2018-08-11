using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    // Use this for initialization
    Rigidbody rb;

    void Start () {

        rb=GetComponent<Rigidbody>();
        float x = Random.Range(50f, 500f);
        float z = Random.Range(-100f, 100f);
        rb.AddForce(new Vector3(x,0,z));

		
    }
	
    // Update is called once per frame
    void Update () {
    }

    void OnCollisionEnter(Collision col){
        Debug.Log("naai nibanda");
        // rb.isKinematic = false;
        // rb.AddForce(new Vector3(0,50f,-50f));
    }
	
}
