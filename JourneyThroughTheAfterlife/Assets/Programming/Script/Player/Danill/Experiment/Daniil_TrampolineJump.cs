using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_TrampolineJump : MonoBehaviour {

	public Daniil_PlayerMovement otherScriptVar;

	public void Start(){
		otherScriptVar = FindObjectOfType<Daniil_PlayerMovement> ();
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			if (this.transform.position.y < other.transform.position.y) {
				Debug.Log ("Hit!");

				otherScriptVar.vertSpeed = otherScriptVar.JumpForce * 2;
			}
		}
	}
}
