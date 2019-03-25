using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float Speed;
	public float JumpForce;
	float vertSpeed; //Resulting vertical speed
	public float minFall;//Allows to walk up and down on uneven terrain
	float terminalVelocity = -10;//Maximum fallspeed
	public CharacterController PlayerController;
	public float GravityScale;

	private Vector3 moveDirection;

	void Update(){

		//Update player position
		moveDirection = new Vector3 (Input.GetAxis ("Horizontal") * Speed, moveDirection.y, Input.GetAxis ("Vertical") * Speed);

		//Jump implementation
		if (PlayerController.isGrounded) {
			if (Input.GetButtonDown ("Jump")) {
				vertSpeed = JumpForce;
			} else {
				vertSpeed = minFall;	
			}
		} else {
			vertSpeed += Physics.gravity.y * 5 * Time.deltaTime;
			if (vertSpeed < terminalVelocity) {
				vertSpeed = terminalVelocity;
			}
		}
		moveDirection.y = vertSpeed;

		moveDirection.y = moveDirection.y + (Physics.gravity.y * GravityScale);
		PlayerController.Move (moveDirection * Time.deltaTime);
	}
}
