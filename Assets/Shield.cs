using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
 
public class Shield : MonoBehaviour {
 
    // Use this for initialization
    void Start () {
 
    }
 
    // Update is called once per frame
    void Update () {
        transform.position = InputTracking.GetLocalPosition(XRNode.RightHand) * 15 + GameObject.Find("Main Camera").transform.position + new Vector3(0f, 2f, 0);  
        transform.eulerAngles = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles;
    }
}