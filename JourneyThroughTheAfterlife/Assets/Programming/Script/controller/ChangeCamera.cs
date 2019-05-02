using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {


	public CameraFollow changeoffset;
	public DialogueTrigger FirstDialogue;
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
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			changeoffset.Offset = new Vector3 (0, 2, -10);
			FirstDialogue.TriggerDialogue ();
		}
	


	}
}
