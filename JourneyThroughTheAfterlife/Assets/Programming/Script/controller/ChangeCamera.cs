﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {


	public CameraFollow changeoffset;
	public DialogueTrigger FirstDialogue;
	public GameObject LightDestroy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			changeoffset.Offset = new Vector3 (-10, 4, 0);
			Destroy (LightDestroy);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {

			Debug.Log (other.gameObject.transform.position.x);
			changeoffset.Offset = new Vector3 (0, 2, -10);
			FirstDialogue.TriggerDialogue ();
		}
	


	}
}
