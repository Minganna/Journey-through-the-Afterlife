using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {


	public JumpOnCanoe Jump;
	public GameObject LightDirection;
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Floor") {
			Jump.CoinCollected = true;
			LightDirection.SetActive (true);
			Destroy (gameObject);

		}
	}

}
