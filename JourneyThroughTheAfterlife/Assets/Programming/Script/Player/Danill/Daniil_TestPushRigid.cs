using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_TestPushRigid : MonoBehaviour {

	public float pushPower = 2.0f;

	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		Rigidbody rB = hit.collider.attachedRigidbody;

		if (rB == null) {
			return;
		}


		Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);

		rB.velocity = pushDir * pushPower;
		Debug.Log ("Hit");
	}
}
