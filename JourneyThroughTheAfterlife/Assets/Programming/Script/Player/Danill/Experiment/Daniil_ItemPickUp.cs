using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_ItemPickUp : MonoBehaviour {

	//Where the items goes( Player's right hand)
	public Vector3 PickUpPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			this.transform.parent = other.transform;
			this.transform.localPosition = PickUpPosition;
		}
	}
}
