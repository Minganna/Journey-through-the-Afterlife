using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnCanoe : MonoBehaviour {
	public GameObject Player;
	public Rigidbody Canoe;
	public bool MoveCanoe;
	public CameraFollow ChangeTarget;
	public DialogueTrigger startConv;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (MoveCanoe) {
			Canoe.AddForce (transform.right);
			ChangeTarget.Target = Canoe.transform;
			startConv.NextSentence ();
		}
		if (MoveCanoe == false) {
			Canoe.velocity = Vector3.zero;
		    Canoe.angularVelocity = Vector3.zero;
	
		}


	}

	void OnTriggerStay( Collider other)
	{

		if (other.tag== "Player"&&Input.GetKeyDown(KeyCode.E)) {
			Player.SetActive (false);
			MoveCanoe = true;

		}

	}


	void OnTriggerEnter( Collider other)
	{
		if (other.tag == "Player") {
			startConv.TriggerDialogue ();
		}
	}
}
