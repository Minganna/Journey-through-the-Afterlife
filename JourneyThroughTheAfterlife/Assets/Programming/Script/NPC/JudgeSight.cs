using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeSight : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log ("Spotted");
		}

	}
}
