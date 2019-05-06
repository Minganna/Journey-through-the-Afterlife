using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_ItemPickUp : MonoBehaviour {

	//Where the items goes( Player's right hand)
	public Vector3 PickUpPosition;
	public Vector3 PickUpRotation;
	public Rigidbody Item;
	public float ThrowForce;
	[SerializeField] bool Interact = false;
	[SerializeField] bool Holding = false;

	// Update is called once per frame
	void Update () {
		if (Interact == true && Input.GetKeyDown("e")) {
			Item.freezeRotation = true;
			Item.velocity = Vector3.zero;
			//Item.useGravity = false;e
			Item.transform.parent = this.transform;
			Item.transform.localPosition = PickUpPosition;
			Item.transform.localEulerAngles = PickUpRotation;
			Holding = true;
		}
		if (Holding == true && Input.GetKeyDown ("q")) {
			Item.freezeRotation = false;
			//Item.useGravity = true;
			Holding = false;
			Item.AddForce (transform.parent.forward * ThrowForce);
			Item.transform.SetParent (null);
			Interact = false;
		}
	}

	private void OnTriggerEnter(Collider other)           
	{
		if (other.tag == "Pickable" && Holding == false) {
			Debug.Log ("Can interact");
			Interact = true;
			Item = other.attachedRigidbody;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Pickable" && Holding == false) {
			Item = null;
		}
	}
}
