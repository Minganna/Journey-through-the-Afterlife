using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeSight : MonoBehaviour {

    public Dissolve dissolve;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player"&&dissolve.CanBeSpotted==true)
		{
			Debug.Log ("Spotted");
		}

	}
}
