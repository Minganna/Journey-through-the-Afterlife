﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_ItemPickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		//if (other.tag == "Player") {
			Debug.Log("Colliding with player!");
		//}
	}
}
