using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JessesPlayerMovement : MonoBehaviour {
	public bool Playtime=true;
	public float MoveSpeed = 0.0f;
	public float JumpForce = 20.0f;
	public float vertSpeed; //Resulting vertical speed
	float terminalVelocity = -10.0f;//Maximum fallspeed
	public CharacterController PlayerController;
	public float GravityScale = 1;

	public float PlayerDirection;

	private Vector3 moveDirection;

	void Start(){

	}

	void FixedUpdate(){
		if (Playtime) {
			//Moving player methods
			//Old version
			//moveDirection = new Vector3 (Input.GetAxis ("Horizontal") * Speed, moveDirection.y, Input.GetAxis ("Vertical") * Speed);

			//Newest version, that allows to move in a direction that player faces.
			//First bracets controlls forward and backward movement, and second bracets controlls right and left movement

			//Normalize the vector, so that we dont go double speed, when moved diagonaly 

			CalculateAngle();
			transform.rotation =  Quaternion.Euler(0, PlayerDirection, 0);
			if(((Input.GetAxis ("Vertical")*2) + (Input.GetAxis ("Horizontal"))*0.5) != 0) moveDirection = (transform.forward);
			moveDirection = moveDirection.normalized * MoveSpeed;

			//Jump method
			//Check if player is on the ground
			if (PlayerController.isGrounded) {
				if (Input.GetButtonDown ("Jump")) {
					vertSpeed = JumpForce;
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
	private void CalculateAngle()
	{
		if (Input.GetAxis ("Vertical") == 1 && Input.GetAxis ("Horizontal") == 1) {
			PlayerDirection = 45 + Camera.main.transform.eulerAngles.y;
		}
		else if (Input.GetAxis ("Vertical") == -1 && Input.GetAxis ("Horizontal") == -1) {
			PlayerDirection = 225 + Camera.main.transform.eulerAngles.y;
		}
		else if (Input.GetAxis ("Vertical") == 1 && Input.GetAxis ("Horizontal") == -1) {
			PlayerDirection = 315 + Camera.main.transform.eulerAngles.y;
		}
		else if (Input.GetAxis ("Vertical") == -1 && Input.GetAxis ("Horizontal") == 1) {
			PlayerDirection = 135 + Camera.main.transform.eulerAngles.y;
		}
		else if (Input.GetAxis ("Horizontal") == 1) {
			PlayerDirection = 90 + Camera.main.transform.eulerAngles.y;
		}
		else if (Input.GetAxis ("Horizontal") == -1) {
			PlayerDirection = 270 + Camera.main.transform.eulerAngles.y;
		}
		else if (Input.GetAxis ("Vertical") == -1) {
			PlayerDirection = 180 + Camera.main.transform.eulerAngles.y;
		}
		else if (Input.GetAxis ("Vertical") == 1) {
			PlayerDirection = 0 + Camera.main.transform.eulerAngles.y;
		}
	}
}
