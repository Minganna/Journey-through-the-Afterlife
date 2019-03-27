using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_PlayerRotation : MonoBehaviour {

	public float RotationSpeed;
	public Transform Target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Mouse X") * RotationSpeed;
		Target.Rotate (0, horizontal, 0);
	}
}
