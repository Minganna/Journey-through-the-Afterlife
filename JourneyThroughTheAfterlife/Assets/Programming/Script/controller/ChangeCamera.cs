using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {


	public CameraFollow changeoffset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter()
	{
		changeoffset.Offset = new Vector3 (-10, 4, 0);
	}
	void OnTriggerExit()
	{
		changeoffset.Offset = new Vector3 (0, 2, -10);
	}
}
