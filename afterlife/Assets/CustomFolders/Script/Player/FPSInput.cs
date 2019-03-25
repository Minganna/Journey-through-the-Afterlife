using UnityEngine;
using System.Collections;

// basic WASD-style movement control
// commented out line demonstrates that transform.Translate instead of charController.Move doesn't have collision detection

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour {
	public float speed = 6.0f;
	public float gravity = -9.8f;

	public float JumpHeight = 15f; //The jump height that player is able to reach
	public float terminalVelocity = -10; //The max fall speed
	public float minFall = -1.5f; //(Negative) speed while on the ground - allows to run up and down on uneven terrain
	private float vertSpeed; //Is the resulting vertical speed


	private CharacterController _charController;
	
	void Start() {
		_charController = GetComponent<CharacterController>();
		vertSpeed = minFall;
	}
	
	void Update() {
		//transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		movement = Vector3.ClampMagnitude(movement, speed);

		//Jump implementation
		if (_charController.isGrounded) 
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				vertSpeed = JumpHeight;
			} 
			else 
			{
				vertSpeed = minFall;	
			}
		}
		else
		{
			vertSpeed += gravity * 5 * Time.deltaTime;
			if (vertSpeed < terminalVelocity) 
			{
				vertSpeed = terminalVelocity;
			}
		}
		movement.y = vertSpeed;

		movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement);
		_charController.Move(movement);
	}
}
