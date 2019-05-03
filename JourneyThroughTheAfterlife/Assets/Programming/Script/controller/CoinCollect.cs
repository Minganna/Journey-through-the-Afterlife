using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {


	public JumpOnCanoe Jump;
	public GameObject LightDirection;
	public Animator CollectCoin;
	public Daniil_PlayerMovement movements;
	public Daniil_PlayerRotation rotation;
	bool fall=true;

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Floor") {
			CollectCoin.SetBool ("PickUpCoin", true);
			movements.Playtime = false;
			rotation.Playtime = false;
			if (fall) {
				fall = false;
				StartCoroutine (CoinTime ());
			}

		}
	}


	IEnumerator CoinTime()
	{
		yield return new WaitForSeconds (1f);
		CollectCoin.SetBool ("PickUpCoin", false);
		movements.Playtime = true;
		rotation.Playtime = true;
		Jump.CoinCollected = true;
		LightDirection.SetActive (true);
		Destroy (gameObject);

	}

}
