using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_TrampolineJump : MonoBehaviour {

	public JessesPlayerMovement otherScriptVar;
	public float addJumpForce;

	public void Start(){
		otherScriptVar = FindObjectOfType<JessesPlayerMovement> ();
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			if (this.transform.position.y < other.transform.position.y) {
				Debug.Log ("Hit!");

				otherScriptVar.vertSpeed = addJumpForce;
			}
		}
	}
}
