﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOffCanoe : MonoBehaviour {

	public JumpOnCanoe OnCanoe;
	public GameObject Player;
	public CameraFollow NewTarget;
	public GameObject PlayerSit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter()
	{
		OnCanoe.MoveCanoe = false;
		Player.transform.position = gameObject.transform.position;
		Player.SetActive(true);
		NewTarget.Target = Player.transform;
		Destroy (PlayerSit);


	}
}
