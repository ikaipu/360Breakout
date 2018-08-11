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
         transform.position = (InputTracking.GetLocalPosition(XRNode.RightHand) - InputTracking.GetLocalPosition(XRNode.Head)) * 15 + new Vector3(-3, 3, 2);  
         transform.eulerAngles = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles;
     }
 }