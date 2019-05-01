using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.RotateAround(gameObject.transform.position,Vector3.right,500*Time.deltaTime);
		
	}
}
