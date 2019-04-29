using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnCanoe : MonoBehaviour {
	public GameObject Player;
	public Rigidbody Canoe;
	private bool MoveCanoe;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (MoveCanoe) {
			Canoe.AddForce (transform.right);
		}
	}

	void OnTriggerEnter()
	{
		Player.SetActive (false);
		MoveCanoe = true;

	}
}
