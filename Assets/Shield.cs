using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
 
public class Shield : MonoBehaviour {
 
    // Use this for initialization
    void Start () {
 
    }
 
    // Update is called once per frame
    void Update ()
    {
        var basePosition = GameObject.Find("Main Camera").transform.position + new Vector3(2f, 4f, 3f);
        var transformPosition = InputTracking.GetLocalPosition(XRNode.RightHand) * 15 + basePosition;
        var transformEulerAngles = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles;
       
        transform.position = transformPosition;    
        transform.eulerAngles = transformEulerAngles;
        transform.RotateAround(basePosition, Vector3.up, 90);
        
    }
}