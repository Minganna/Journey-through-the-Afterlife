using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_PlayerRotation : MonoBehaviour {

	public float RotationSpeed;
	public Transform Target;

	// Use this for initialization
	void Start () {
		RotationSpeed = 10;
		Target = GetComponent<Transform>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.anyKey == false) {
			float horizontal = Input.GetAxis ("Mouse X") * RotationSpeed;
			Target.Rotate (0, horizontal, 0);
		}
	}
}
