using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera2 : MonoBehaviour {

	public CameraFollow cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			cam.Offset = new Vector3 (-10, 4, 0);
		}
	}
}
