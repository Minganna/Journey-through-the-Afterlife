using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Daniil_CageActivateFall : MonoBehaviour {

	public Rigidbody RigBod;
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Minotaur") {
			RigBod.useGravity = true;
		}
	}
}
