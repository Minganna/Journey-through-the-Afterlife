using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniil_PlayerMovement : MonoBehaviour {

	//As for now better not to change this values 
	public float MoveSpeed = 10.0f;
	public float JumpForce = 20.0f;
	public float vertSpeed; //Resulting vertical speed
	float terminalVelocity = -10.0f;//Maximum fallspeed
	public CharacterController PlayerController;
	public float GravityScale = 1;
	bool Diagonal = false;

	private Vector3 moveDirection;

	public Daniil_HUD Hud;


	void Start(){
		PlayerController = GetComponent<CharacterController>(); 

	}

	void Update(){

		//Moving player methods
		//Old version
		moveDirection = new Vector3 (Input.GetAxis ("Horizontal") * MoveSpeed, moveDirection.y, Input.GetAxis ("Vertical") * MoveSpeed);
		//Diagonal rotations
		//Reference
		//PlayerController.transform.rotation = Quaternion.Euler (0, -45, 0);
		//Debug.Log ("w+a pressed");
		if (Input.GetKey (KeyCode.W)) {
			if (Diagonal == false) {
				PlayerController.transform.rotation = Quaternion.Euler (0, 0, 0);
			}
			if (Input.GetKey (KeyCode.A)) {
				Diagonal = true;
				PlayerController.transform.rotation = Quaternion.Euler (0, -45, 0);
			}

			if (Input.GetKey (KeyCode.D)) {
				Diagonal = true;
				PlayerController.transform.rotation = Quaternion.Euler (0, 45, 0);
			}
		} 
		else {
			Diagonal = false;
		}
		if (Input.GetKey (KeyCode.A) && Diagonal == false) {
			PlayerController.transform.rotation = Quaternion.Euler (0, -90, 0);
		}
		if (Input.GetKey (KeyCode.D) && Diagonal == false) {
			PlayerController.transform.rotation = Quaternion.Euler (0, 90, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			PlayerController.transform.rotation = Quaternion.Euler (0, 180, 0);
			if (Input.GetKey (KeyCode.A)) {
				Diagonal = true;
				PlayerController.transform.rotation = Quaternion.Euler (0, 225, 0);
			}

			if (Input.GetKey (KeyCode.D)) {
				Diagonal = true;
				PlayerController.transform.rotation = Quaternion.Euler (0, 135, 0);
			}
		}
		else {
			Diagonal = false;
		}

		//Newest version, that allows to move in a direction that player faces.
		//First bracets controlls forward and backward movement, and second bracets controlls right and left movement
		//moveDirection = (transform.forward * Input.GetAxis ("Vertical")) + (transform.right * Input.GetAxis ("Horizontal"));
		//Normalize the vector, so that we dont go double speed, when moved diagonaly 
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
