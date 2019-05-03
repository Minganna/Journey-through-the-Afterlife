using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnCanoe : MonoBehaviour {
	public GameObject Player;
	public Rigidbody Canoe;
	public bool MoveCanoe;
	public CameraFollow ChangeTarget;
	public DialogueTrigger startConv;
	public bool CoinCollected=false;
	public GameObject DestroyLight;
	public GameObject PlayerOnCanoe;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (MoveCanoe) {
			Canoe.AddForce (transform.right);
			ChangeTarget.Target = Canoe.transform;
			startConv.NextSentence ();
			CoinCollected = false;
			Destroy (DestroyLight);
			PlayerOnCanoe.SetActive (true);

		}
		if (MoveCanoe == false) {
			Canoe.velocity = Vector3.zero;
		    Canoe.angularVelocity = Vector3.zero;
	
		}

		if (CoinCollected == true)
		{
			ChangeTarget.Offset =new Vector3(0,2,+10);
		}


	}

	void OnTriggerStay( Collider other)
	{
		if (CoinCollected == true) {
			if (other.tag == "Player" && Input.GetKeyDown (KeyCode.E)) {
				Player.SetActive (false);
				MoveCanoe = true;

			}
		}

	}


	void OnTriggerEnter( Collider other)
	{
		if (CoinCollected == true) {
			if (other.tag == "Player") {
				startConv.TriggerDialogue ();
			}
		}
	}
}
