using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour {

	public GameObject snake;
	Animator anim;

	void start (){
		anim = snake.GetComponent<Animator> ();
	}

	private void OnTriggerEnter ()
	{
		snake.GetComponent<Animator> ().SetBool ("Player Close", true);
	}

}
